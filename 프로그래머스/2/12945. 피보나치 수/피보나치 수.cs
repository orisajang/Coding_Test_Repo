using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int n) {
        int answer = 0;
        List<long> fibonazziList = new List<long>();
        fibonazziList.Add(0);
        fibonazziList.Add(1);
        
        for(int i=2; i<= n; i++)
        {
            long k = (fibonazziList[i-2] + fibonazziList[i-1]) % 1234567;
            fibonazziList.Add(k);
        }
        
        answer = (int)fibonazziList[n];
        return answer;
    }
}