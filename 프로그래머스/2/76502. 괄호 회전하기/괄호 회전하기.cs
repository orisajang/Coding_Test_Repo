using System;
using System.Collections.Generic;
public class Solution {
    
    public string rotate(string str, int index)
    {
        string msg = "";
        char[] ch = str.ToCharArray();
        for(int i=index; i<str.Length; i++)
        {
            msg += ch[i];
        }
        for(int i=0; i< index; i++)
        {
            msg += ch[i];
        }
        return msg;
    }
    
    public int solution(string s) {
        int answer = 0;
        string str;
        
        Stack<char> st = new Stack<char>();
        for(int i=0; i< s.Length; i++)
        {
            str = rotate(s,i);
            bool isCorrect = true;
            for(int j=0; j< str.Length; j++)
            {
                char c = str[j];
                if(c == ')' || c == '}' || c == ']')
                {
                    if(st.Count == 0 ) 
                    {
                        isCorrect = false;
                        break;
                    }
                    char popCh = st.Pop();
                    
                    if(!((popCh == '(' && c == ')') ||
                         (popCh == '{' && c == '}') ||
                         (popCh == '[' && c == ']')))
                    {
                        isCorrect = false;
                        break;
                    }
                }
                else
                {
                    st.Push(str[j]);
                }
            }
            if(st.Count > 0) isCorrect = false;
            if(isCorrect) answer++;
        }
        
        return answer;
    }
}