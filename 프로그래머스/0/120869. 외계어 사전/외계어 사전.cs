using System;

public class Solution {
    public int solution(string[] spell, string[] dic) {
        int answer = 0;
        
        foreach(string str in dic)
        {
            if(spell.Length != str.Length) continue;
            
            bool isTrue = true;
            foreach(string s in spell)
            {
                if(!str.Contains(s))
                {
                    isTrue = false;
                    break;
                }
            }
            if(isTrue) return 1;
        }
        
        return 2;
    }
}