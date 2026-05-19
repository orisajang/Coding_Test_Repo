using System;

public class Solution {
    public string solution(string[] id_pw, string[,] db) {
        string answer = "";
        
        bool isIdMatch = false;
        
        for(int i=0; i< db.GetLength(0); i++)
        {
            if(id_pw[0] == db[i,0])
            {
                isIdMatch = true;
                if(id_pw[1] == db[i,1])
                {
                    return "login";
                }
            }
        }
        if(isIdMatch)
        {
            return "wrong pw";
        }
        return "fail";
        
        return answer;
    }
}