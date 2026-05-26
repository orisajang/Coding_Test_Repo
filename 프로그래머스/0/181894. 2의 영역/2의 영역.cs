using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        //2가 2개이상이면 해당 배열까지 쭉 만들어서 반환
        //2가 1개면 2만 반환
        //2가 없으면 -1 반환
        List<int> list = new List<int>();
        int startPos = -1;
        int endPos = -1;
        for(int i=0; i< arr.Length; i++)
        {
            if(arr[i] == 2)
            {
                if(startPos == -1)
                {
                    startPos = i;
                }
                else
                {
                    endPos = i;
                }
            }
        }
        //결과로 만들자
        int[] answer;
        if(startPos == -1)
        {
            answer = new int[1];
            answer[0] = -1;
        }
        else if(endPos == -1)
        {
            answer = new int[1];
            answer[0] = 2;
        }
        else
        {
            answer = new int[endPos - startPos + 1];
            int index = 0;
            for(int i= startPos; i<= endPos; i++)
            {
                answer[index] = arr[i];
                index++;
            }
        }
        
        return answer;
    }
}