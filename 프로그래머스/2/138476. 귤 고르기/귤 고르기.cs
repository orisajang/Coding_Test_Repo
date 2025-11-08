using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int k, int[] tangerine) {
        int answer = 0;
        //tangerine에 나올 숫자값이 커서 Dictionary로 확인필요
        Dictionary<int,int> dic = new Dictionary<int,int>();
        for(int i=0; i< tangerine.Length; i++)
        {
            int curNum = tangerine[i];
            if(dic.ContainsKey(curNum))
            {
                dic[curNum]++;
            }
            else 
            {
                dic[curNum] = 1;
            }
        }
        //딕셔너리 값을 리스트로 (링큐)
        List<int> fruitList = dic.Values.ToList();
        //내림차순 정렬
        fruitList.Sort();
        fruitList.Reverse();
        //갯수세서 반환
        int count =0;
        for(int i=0; i< fruitList.Count; i++)
        {
            count += fruitList[i];
            answer++;
            if(count >= k) break;
        }
        return answer;
    }
}