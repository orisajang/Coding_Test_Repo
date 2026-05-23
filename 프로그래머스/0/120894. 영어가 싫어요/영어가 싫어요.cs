using System;

public class Solution {
    public long solution(string numbers) {
        long answer = 0;
        string plusNum = "";
        string str = "";
        for(int i=0; i< numbers.Length; i++)
        {
            plusNum += numbers[i];
            string strBuf = CheckString(plusNum);
            if(strBuf != "")
            {
                str += strBuf;
                plusNum = "";
            }
        }
        return long.Parse(str);
    }
    public string CheckString(string str)
    {
        if(str == "zero") return "0";
        else if(str == "one") return "1";
        else if(str == "two") return "2";
        else if(str == "three") return "3";
        else if(str == "four") return "4";
        else if(str == "five") return "5";
        else if(str == "six") return "6";
        else if(str == "seven") return "7";
        else if(str == "eight") return "8";
        else if(str == "nine") return "9";
        
        return "";
    }
}