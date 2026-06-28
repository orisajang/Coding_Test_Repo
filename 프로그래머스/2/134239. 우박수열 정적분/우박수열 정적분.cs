using System;
using System.Collections.Generic;

public class Solution {
    public double[] solution(int k, int[,] ranges) {
        //직사각형이 아니라 사다리꼴 형태로 나타나므로 사다리꼴 공식으로 해야한다
        double[] answer = new double[ranges.GetLength(0)];
        //1. 주어진 수가 몇번만에 1이 되는지부터 확인해보자
        List<int> ubakList = new List<int>();
        ubakList.Add(k);
        while(k != 1)
        {
            if(k %2 == 0) k= k / 2;
            else k = (k*3) +1;
            ubakList.Add(k);
        }
        //2. 이걸 기준으로 이제 각각의 적분결과를 구하자
        for(int i=0; i< ranges.GetLength(0); i++)
        {
            int start = ranges[i,0];
            int end = ubakList.Count + ranges[i,1];
            
            if(end <= start) 
            { 
                answer[i] = -1; 
                continue;
            }
            double sum = 0;
            
            for(int j=start; j < end-1; j++)
            {
                //이제 적분으로 하나씩 더해보자.
                //(왼쪽높이 + 오른쪽높이) /2 * 가로 -> 사다리꼴 공식
                double result = (ubakList[j] + ubakList[j+1]) /2.0; 
                sum += result;
            }
            answer[i] = sum;
        }
        return answer;
    }
}