using System;
using System.Collections.Generic;

public class Solution {
    public long Max(long a, long b)
    {
        return a>b ? a:b;
    }
    
    public int[] solution(int n, long left, long right) {
        int arrSize = (int)(right - left) +1;
        int[] answer = new int[arrSize];
        
        long minI = left / n; //1
        long maxI = right / n; //2
        
        int arrIndex = 0;
        bool isFinish = false;
        for(long i=minI; i<=maxI; i++)
        {
            if(isFinish) break;
            for(long j=0; j<n; j++)
            {
                long index = (i*n) + j;
                if(left <= index && index <= right)
                {
                    long addNum = Max(i+1,j+1);
                    answer[arrIndex] = (int)addNum;
                    arrIndex++;
                    if(arrSize == arrIndex)
                    {
                        isFinish = true;
                        break;
                    }
                }
            }
        }
        /*
        //아래는 모범 답안
        int len = (int)(right - left +1);
        int[] answer = new int[len];
        for(long i=0; i< len; i++)
        {
            long idx = left + i;
            //2,3,4,5
            int row = (int)(idx / n);
            int col = (int)(idx % n);
            answer[i] = Math.Max(row+1,col+1);
        }
        */
        return answer;
    }
}