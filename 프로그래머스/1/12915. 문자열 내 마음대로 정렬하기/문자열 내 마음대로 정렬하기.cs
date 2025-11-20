using System;
using System.Collections.Generic;
using System.Text;
public class Solution {
    public string[] solution(string[] strings, int n) {
        string[] answer = new string[strings.Length];
        
        for(int i=0; i< strings.Length; i++)
        {
            answer[i] = strings[i][n] + strings[i];
        }
        Array.Sort(answer);
        for(int i=0; i< strings.Length; i++)
        {
            StringBuilder sb = new StringBuilder();
            for(int j=1; j< answer[i].Length; j++)
            {
                sb.Append(answer[i][j]);
            }
            answer[i] = sb.ToString();
        }
        
        return answer;
    }
}