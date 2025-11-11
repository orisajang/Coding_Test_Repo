using System;
using System.Text;
public class Solution {
    
    private char CheckOverChar(int plusNum,char currentCh, char minCh, char maxCh)
    {
        char ch;
        StringBuilder sb = new StringBuilder();
        int num = currentCh + plusNum;
        if((num / (maxCh+1)) != 0 )
        {
            ch = (char)(minCh + (num % (maxCh + 1)));
        }
        else
        {
            ch = (char)num;
        }
        return ch;
    }
    public string solution(string s, int n) {
        string answer = "";
        StringBuilder sb = new StringBuilder();
        for(int i=0; i< s.Length; i++)
        {
            if(s[i] == ' ')
            {
                sb.Append(" ");
                continue;
            }
            char c;
            if('a' <= s[i] && s[i] <= 'z')
            {
                c = CheckOverChar(n,s[i],'a','z');
                sb.Append(c);
            }
            else if('A' <= s[i] && s[i] <= 'Z')
            {
                c = CheckOverChar(n,s[i],'A','Z');
                sb.Append(c);
            }
        }
        answer = sb.ToString();
        return answer;
    }
}