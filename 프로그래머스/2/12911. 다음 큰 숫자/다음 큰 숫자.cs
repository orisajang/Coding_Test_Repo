using System;

class Solution 
{
    public int OneCount(int num)
    {
        int count =0;
        while(num > 0)
        {
            int k = num %2; // 1 갯수 파악
            if(k == 1) count++;
            num /=2;
        }
        return count;
    }
    public int solution(int n) 
    {
        int answer = 0;
        //n보다 크고, n과 2진수변환시 1의 갯수가 같을때,
        int nOneCount = OneCount(n);
        answer = n;
        while(true)
        {
            answer++;
            int currentOneCount = OneCount(answer);
            if(nOneCount == currentOneCount) break;
        }
        return answer;
    }
}