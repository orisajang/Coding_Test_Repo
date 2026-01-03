using System;
using System.Text;

public class Solution {
    public string solution(string[] str_list, string ex) {
        string answer = "";
        StringBuilder sb = new StringBuilder();
        int exLength = ex.Length;
        for(int i=0; i< str_list.Length; i++)
        {
            string str = str_list[i];
            
            int index = 0;
            for(int j=0; j<str.Length; j++)
            {
                if(index >= exLength)
                {
                    break;
                }
                
                if(str[j] == ex[index])
                {
                    index++;
                }
                else 
                {
                    index = 0;
                }
            }
            if(index < exLength)
            {
                sb.Append(str);
            }
        }
        
        answer = sb.ToString();
        
        return answer;
    }
}