using System;

public class Solution {
    
    private char UnderToUpper(char ch)
    {
        char c = ch;
        if('a' <= ch  && ch <= 'z')
        {
            c =  (char)(ch - ('a' - 'A'));    
        }
        return c;
    }
    private char UpperToUnder(char ch)
    {
        char c = ch;
        if('A' <= ch  && ch <= 'Z')
        {
            c =  (char)(ch + ('a' - 'A'));    
        }
        return c;
    }
    
    public string solution(string s) {
        string answer = "";
        //짝수번째는 대문자, 홀수번째는 소문자로 만들어야함
        int count = 0;
        for(int i=0; i< s.Length; i++)
        {
            if(s[i] == ' ') 
            {
                count = 0;
                answer += " ";
                continue;
            }
            if(count % 2 == 0)
            {
                answer += UnderToUpper(s[i]);
            }
            else
            {
                answer += UpperToUnder(s[i]);
            }
            count++;
        }
        
        return answer;
    }
}