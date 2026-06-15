using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string number, int k) {
        string answer = "";
        Stack<int> st = new Stack<int>();
        for(int i=0; i< number.Length; i++)
        {
            int num = number[i] - '0';
            if(k == 0 || st.Count == 0)
            {
                st.Push(num);
            }
            else
            {
                while(k > 0 && st.Count > 0)
                {
                    if(st.Peek() >= num) break;
                    k--;
                    st.Pop();
                }
                st.Push(num);
            }
        }
        //k가 남아있으면 하나씩 스택 빼자
        while(k > 0)
        {
            k--;
            st.Pop();
        }
        char[] ch = new char[st.Count];
        int index = st.Count -1;
        while(st.Count > 0)
        {
            ch[index] = (char)(st.Pop() + '0');
            index--;
        }
        answer = new string(ch);
        
        return answer;
    }
}