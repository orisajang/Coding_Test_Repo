using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        //List로 확인
        //skip에 포함되는 알파벳은 s에 포함되지않음
        List<char> listArray = new List<char>();
        for(int i=0; i< 26; i++)
        {
            char c = (char)('a' + i);
            if(!skip.Contains(c)) listArray.Add(c);
        }
        int listCount = listArray.Count;
        
        for(int i=0; i<s.Length; i++)
        {
            char ch = s[i];
            int charIndex = 0;
            for(int j=0; j<listCount; j++) //ch의 Index찾기 (charArray에서)
            {
                if(ch == listArray[j]) 
                {
                    charIndex = j;
                    break;
                }
            }
            int chIndex = (charIndex + index) % listCount;
            answer += listArray[chIndex];
        }
        return answer;
    }
}