using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] picks, string[] minerals) {
        int answer = 0;
        int pickLimit = 5;
        
        int maxCount = minerals.Length;
        int picksCount = 0;
        for(int i=0; i< picks.Length; i++)
        {
            picksCount += picks[i];
        }
        if(picksCount * pickLimit < minerals.Length)
        {
            maxCount = picksCount * pickLimit;
        }
        Console.WriteLine(picksCount);
        Console.WriteLine(maxCount);
        //곡괭이 1번 장착하면? 계속 써야함. 우선도를 결정해볼까?
        //고급 곡괭이는 무조건 쓴다 보면 될듯? 다만 언제 쓸지 결정을 해야함.
        //총 필요한 곡괭이 수를 구하자
        int count = (maxCount / pickLimit);
        if(maxCount % pickLimit != 0 ) count++;
        
        //이제 구간별로 총 몇의 피로도가 필요한지 구해보자
        List<(int,int)> list = new List<(int,int)>();
        for(int i=0; i< count; i++)
        {
            list.Add((i,0));
        }
        for(int i=0; i< maxCount; i++)
        {
            //현재 인덱스
            int index = i / pickLimit;
            int amount = 1;
            if(minerals[i] == "diamond")
            {
                amount = 25;
            }
            else if(minerals[i] == "iron")
            {
                amount = 5;
            }
            var (num1,num2) = list[index];
            num2 += amount;
            list[index] = (num1,num2);
        }
        //이제 오름차순 정렬
        list.Sort( (a,b) => b.Item2.CompareTo(a.Item2));
        Dictionary<int,int> dict = new Dictionary<int,int>();
        List<int> resList = new List<int>();

        for(int i=0; i< list.Count; i++)
        {
            //가장 큰곳부터 시작해서 pick에 있는 곡괭이를 하나 가져가도록 하자
            int index = list[i].Item1;
            int type = -1;
            //어떤 곡괭이를 줄지 결정해보자
            for(int j=0; j< picks.Length; j++)
            {
                if(picks[j] > 0)
                {
                    type = j;
                    picks[j]--;
                    break;
                }
            }
            
            if(!dict.ContainsKey(index))
            {
                dict.Add(index, type);
            }
        }
        //이제 돌면서 피로도 계산을 해보자
        for(int i=0; i< maxCount; i++)
        {
            int index = i / pickLimit;
            int type = dict[index];
            int amount = 1;
            if(type == 1)
            {
                if(minerals[i] == "diamond")
                {
                    amount = 5;
                }
            }
            else if(type == 2)
            {
                if(minerals[i] == "diamond")
                {
                    amount = 25;
                }
                else if(minerals[i] == "iron")
                {
                    amount = 5;
                }
            }
            //Console.WriteLine($"{type}, {amount}");
            answer += amount;
        }
        
        return answer;
    }
}