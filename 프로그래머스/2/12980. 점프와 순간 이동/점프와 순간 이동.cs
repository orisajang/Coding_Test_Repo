using System;

class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        //2진수개념으로 1이나올때마다 점프해야함
        while(n != 0)
        {
            if(n%2 != 0) answer++;
            n/= 2;
        }
        return answer;
    }
}