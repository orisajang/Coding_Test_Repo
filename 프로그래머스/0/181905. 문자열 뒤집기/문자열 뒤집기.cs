using System;

public class Solution {
    public string solution(string my_string, int s, int e) {
        string answer = "";
        char[] chars = my_string.ToCharArray();
        //1. swap으로 푸는방법 s++, e--;
        while(s < e)
        {   
            char buf = chars[s];
            chars[s] = chars[e];
            chars[e] = buf;
            s++;
            e--;
        }
        
        answer = new string(chars);
        return answer;
    }
}