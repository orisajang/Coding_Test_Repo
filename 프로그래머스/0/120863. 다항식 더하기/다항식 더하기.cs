using System;
using System.Linq;

public class Solution {
    public string solution(string polynomial) {
        string answer = "";
        
        string[] msg = polynomial.Split(' ').ToArray();
        int numX = 0;
        int number = 0;
        
            for (int i = 0; i < msg.Length; i++)
            {
                if (msg[i] == "+") continue;

                int buf = 0;
                if (msg[i].Contains("x"))
                {
                    //string[] ss = msg[i].Split('x').ToArray();
                    string temp = msg[i].Replace("x", "");
                    if(temp == "")
                    {
                        numX += 1;
                    }
                    else
                    {
                        numX += int.Parse(temp);
                    }
                }
                else
                {
                    buf = int.Parse(msg[i]);
                    number += buf;
                }
            }
        //결과
        if(number == 0) 
        {
            if(numX == 1)
            {
                return "x";
            }
            return numX.ToString() + "x";
        }
        if(numX == 0) return number.ToString();
        if(numX == 1) return "x + " + number;
        
        
        
        
        answer = $"{numX}x + {number}";
        
        
        return answer;
    }
}