using System;
using System.Text;
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
        StringBuilder sb = new StringBuilder();
        //짝수번째는 대문자, 홀수번째는 소문자로 만들어야함
        int count = 0;
        for(int i=0; i< s.Length; i++)
        {
            if(s[i] == ' ') 
            {
                count = 0;
                sb.Append(" ");
                continue;
            }
            if(count % 2 == 0)
            {
                sb.Append(UnderToUpper(s[i]));
            }
            else
            {
                sb.Append(UpperToUnder(s[i]));
            }
            count++;
        }
        
        answer = sb.ToString();
        return answer;
    }
}