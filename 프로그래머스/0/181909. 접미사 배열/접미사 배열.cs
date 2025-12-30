using System;
using System.Text;

public class Solution {
    public string[] solution(string my_string) {
        string[] answer = new string[my_string.Length];
        
        //방법2
        for(int i=0; i< my_string.Length; i++)
        {
            answer[i] = my_string.Substring(i);
        }
        Array.Sort(answer);
        
        
        return answer;
    }
}