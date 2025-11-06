using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        List<int> dayList = new List<int>();
        for(int i=0; i< progresses.Length; i++)
        {
            int num = (100 - progresses[i]) / speeds[i];
            if(((100 - progresses[i]) % speeds[i]) != 0) num++; //나머지있었으면 +1
            dayList.Add(num);
        }
        
        List<int> bapoList = new List<int>();
        int index = 0;
        bool isFinish = false;
        while(!isFinish)
        {
            int firstDay = 0;
            int bapoCount = 1;
            
            for(int i= index; i< dayList.Count; i++)
            {
                if(i == index) firstDay = dayList[i];
                else
                {
                    int num2 = dayList[i] - firstDay;
                    if(num2 <= 0)  bapoCount++;
                    else
                    {
                        index = i;
                        bapoList.Add(bapoCount);
                        break;
                    }
                }
                
                if(i== dayList.Count-1)
                {
                    bapoList.Add(bapoCount);
                    isFinish = true;
                    break;
                }
            }
        }
        
        int[] answer = new int[bapoList.Count];
        for(int i=0; i<bapoList.Count; i++)
        {
            answer[i] = bapoList[i];
        }
        
        
        return answer;
    }
}