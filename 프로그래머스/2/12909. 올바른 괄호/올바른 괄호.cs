using System;
using System.Collections.Generic;
public class Solution {
    public bool solution(string s) {
        bool answer = true;
        Queue<char> que = new Queue<char>();
        //queue로 해결, (가 있을때 )가 들어오면 pop, '('가 없다면? ? false
        
        for(int i=0; i< s.Length; i++)
        {
            if(s[i] == '(')
            {
                que.Enqueue('(');
            }
            else if(s[i] == ')')
            {
                if(que.Count != 0) que.Dequeue();
                else{
                    answer = false;
                    break;
                }
            }
        }
        
        //'(' 가 남아있으면 false
        if(que.Count != 0) answer = false;
        
        return answer;
    }
}