using System;

public class Solution {
    public string solution(string my_string, int s, int e) {
        string answer = "";
        char[] chars = my_string.ToCharArray();
        int index = 0;

        for(int i=s; i<= e; i++)
        {
            char c = my_string[e - index];
            chars[i] = c;
            index++;
        }
        answer = new string(chars);
        
        return answer;
    }
}