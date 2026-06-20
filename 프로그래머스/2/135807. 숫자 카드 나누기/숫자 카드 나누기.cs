using System;

public class Solution {
    public int solution(int[] arrayA, int[] arrayB) {
        int answer = 0;
        int gcdA = arrayA[0];
        int gcdB = arrayB[0];
        
        for(int i=1; i < arrayA.Length; i++)
        {
            gcdA = GCD(gcdA,arrayA[i]);
            gcdB = GCD(gcdB,arrayB[i]);
        }
        
        //바로 최대 공약수로 두번 체크해보자
        bool isTrueA = true;
        bool isTrueB = true;
        for(int i=0; i< arrayA.Length; i++)
        {
            if(gcdB == 0 ||  arrayA[i] % gcdB == 0) 
            {
                isTrueA = false;
                break;
            }
        }
        for(int i=0; i< arrayB.Length; i++)
        {
            if(gcdA ==0 || arrayB[i] % gcdA == 0) 
            {
                isTrueB = false;
                break;
            }
        }
        //조건문 체크한다음에 큰수 찾기
        if(isTrueA && isTrueB)
        {
            if(gcdA >= gcdB) answer = gcdA;
            else answer = gcdB;
        }
        else if(isTrueA)
        {
            answer = gcdB;
        }
        else if(isTrueB)
        {
            answer = gcdA;
        }
        else
        {
            answer = 0;
        }
        
        
        
        return answer;
    }
    
    private int GCD(int a, int b)
    {
        
        while(b != 0)
        {
            int buf = a % b;
            a = b;
            b = buf;
        }
        return a;
    }
}