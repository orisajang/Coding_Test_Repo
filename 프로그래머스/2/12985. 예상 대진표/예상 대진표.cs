using System;
class Solution
{
    public int solution(int n, int a, int b)
    {
        int answer = 0;
        //처음에 몫과 나머지를 더한값이 서로 같다면? 같은 것 바로 끝냄
        int div = 1;
        while(true)
        {
            a = (a/2) + a % 2;
            b = (b/2) + b % 2;
            
            if(a ==0 && b==0)
            {
                //뭔가 이상함 
            }
            else if(a == 0)
            {
                a = 1;
            }
            else if(b == 0)
            {
                b = 1;
            }
            if(a==b)
            {
                return div;
            }
            div++;
        }

        return answer;
    }
}