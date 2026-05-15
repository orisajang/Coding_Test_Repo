using System;

public class Solution {
    public int solution(int a, int b) {
        //기약분수로 나타내기
        int gcd = GCD(a,b);
        b /= gcd;
        //조건판별
        while(b %2 == 0)
        {
            b /= 2;
        }
        while(b %5 == 0)
        {
            b /= 5;
        }
        return (b == 1) ? 1 : 2;
    }
    
    public int GCD(int a, int b)
    {
        while(b != 0)
        {
            int num = a % b;
            a = b;
            b = num;
        }
        return a;
    }
}