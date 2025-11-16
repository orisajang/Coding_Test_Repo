using System;
using System.Collections.Generic;

public class Solution {
    
    public bool CheckSameToTarget(Dictionary<string,int> dicTarget, Dictionary<string,int> dic2)
    {
        bool isSame = true;
        foreach(var item in dicTarget.Keys)
        {
            if(!dic2.ContainsKey(item)) 
            {
                isSame = false;
                break;
            }
            
            if(!(dicTarget[item] == dic2[item]))
            {
                isSame = false;
                break;
            }
        }
        return isSame;
    }
    
    public int solution(string[] want, int[] number, string[] discount) {
        int answer = 0;
        //want딕셔너리와 현재 10개가 들어있는 것들을 딕셔너리에 담음.
        //처음 10개만 담고 그다음부터는 1개씩 다음으로 가면서 이전꺼는뺴고 현재꺼를 더함
        //want와 갯수가 전부 맞으면?  OK 아니면 0반환
        Dictionary<string,int> dicWant = new Dictionary<string,int>();
        Dictionary<string,int> dic = new Dictionary<string,int>();
        //원하는 물건을 담은 딕셔너리 초기화
        for(int i=0; i< want.Length; i++)
        {
            dicWant[want[i]] = number[i];
        }
        //초기10개의 딕셔너리를 담는다
        for(int i=0; i< 10; i++)
        {
            if(!dic.ContainsKey(discount[i])) dic[discount[i]] = 1;
            else dic[discount[i]]++;
        }
        if(CheckSameToTarget(dicWant,dic)) answer++;
        
        for(int i=10; i< discount.Length; i++)
        {
            //0번째랑 10번째랑 바꾸어야함. 0번째는 빼고 10번째는 더해
            string before = discount[i-10];
            string now = discount[i];
            dic[before]--;
            if(!dic.ContainsKey(now)) dic[now] = 1;
            else dic[now]++;
            if(CheckSameToTarget(dicWant,dic)) answer++;
        }

        return answer;
    }
}