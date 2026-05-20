using System;

public class Solution {
    public int[] solution(int[,] score) {
        int lengthX = score.GetLength(0);
        int[] answer = new int[lengthX];
        for(int i=0; i< lengthX; i++)
        {
            answer[i] = 1;
        }
        //모든곳을 돌면서 자신의 합과 다른곳의 합을 결정하기
        for(int i=0; i< lengthX; i++)
        {
            float sum1 = score[i,0] + score[i,1];
            for(int j=i+1; j < lengthX; j++)
            {
                float sum2 = score[j,0] + score[j,1];
                if(sum1 < sum2)
                {
                    answer[i]++;
                }
                else if(sum1 > sum2)
                {
                    answer[j]++;
                }
            }
        }

        return answer;
    }
}