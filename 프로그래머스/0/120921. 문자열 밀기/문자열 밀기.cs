using System;

public class Solution {
    public int solution(string A, string B) {
        int length = A.Length;
        for(int i=0; i< length; i++)
        {
            string ss = A.Substring(length-i,i) + A.Substring(0,length-i);
            Console.WriteLine(ss);
            if(ss == B)
            {
                return i;
            }
        }
        
        
        return -1;
    }
}