using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] ingredient) {
        int answer = 0;
        //빵,야채,고기,빵
        //중간에 값을 빼야함 (스택과 큐는 뒤의 값을 빼기때문에 좀 그런듯)
        //RemoveRange를 써보자
        
        //리스트에 저장
        List<int> ingreList = new List<int>();
        for(int i=0; i<ingredient.Length; i++)
        {
            ingreList.Add(ingredient[i]);
        }
        //for문 돌면서 조건 확인
        for(int i=0; i<ingreList.Count -3; i++)
        {   
            //조건이 빵 야채 고기 빵 이므로 순서대로
            if(ingreList[i] == 1 &&
               ingreList[i+1] == 2 &&
               ingreList[i+2] == 3 &&
               ingreList[i+3] == 1)
            {
                answer++;
                ingreList.RemoveRange(i,4);
                //줄어든 인덱스만큼 i 처리
                i = i - 3;
                if(i<0) i=-1;
            }
        }
        
        Console.WriteLine(answer);
        return answer;
    }
}