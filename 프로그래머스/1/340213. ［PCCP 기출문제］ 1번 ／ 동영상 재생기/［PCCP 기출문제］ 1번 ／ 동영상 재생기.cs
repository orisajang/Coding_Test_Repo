using System;
using System.Linq;

public class Solution {
    
    int maxTimeValue = 0;
    int openStartTime = 0;
    int openEndTime  = 0;
    public string solution(string video_len, string pos, string op_start, string op_end, string[] commands) 
    {
        string answer = "";
        //동영상 길이, 현재 길이, 오프닝 영역 안일경우 오프닝 스킵 가능 , 명령어, 시간후 결과출력필요
        maxTimeValue = ConvertTimeToInt(video_len);
        openStartTime = ConvertTimeToInt(op_start);
        openEndTime = ConvertTimeToInt(op_end);
        for(int i=0; i< commands.Length; i++)
        {
            if(commands[i] == "next")
            {
                pos = CalcTimeValue(pos, 10);
            }
            else if(commands[i] == "prev")
            {
                pos = CalcTimeValue(pos, -10);
            }
        }
        //마지막에 자리수를 체워줘야한다.
        
        return pos;
    }
    //계산 필요
    string CalcTimeValue(string currentTime ,int amount)
    {
        int current = ConvertTimeToInt(currentTime);
        if(isOpening(openStartTime, openEndTime, current))
        {
            current = openEndTime;
        }
        current += amount;
        //0이하일경우 0으로, 최대값일경우 최대로 설정 필요
        if(current < 0) 
        {
            current = 0;
        }
        else if(current > maxTimeValue )
        {
            current = maxTimeValue;
        }
        if(isOpening(openStartTime, openEndTime, current))
        {
            current = openEndTime;
        }
        return ConvertIntToTime(current);
    }
    
    bool isOpening(int opStartTime, int opEndTime, int inputTime)
    {
        if(opStartTime <= inputTime && inputTime <= opEndTime)
        {
            return true;
        }
        return false;
    }
    
    
    int ConvertTimeToInt(string time)
    {
        string[] intArray = time.Split(":");
        int min = int.Parse(intArray[0]);
        int sec = int.Parse(intArray[1]);
        return (min * 60) + sec;
    }
    string ConvertIntToTime(int time)
    {
        int min = time / 60;
        int sec = time % 60;
        return $"{min:00}:{sec:00}";
    }
    
}