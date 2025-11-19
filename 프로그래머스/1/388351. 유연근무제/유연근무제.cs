using System;

public class Solution {
    public int solution(int[] schedules, int[,] timelogs, int startday) {
        int answer = 0;
        for(int i=0; i< schedules.Length; i++)
        {
            bool isSuccess = true;
            int timeLength = timelogs.GetLength(1);
            
            for(int j=0; j<timeLength; j++)
            {
                //토요일, 일요일은 넘김
                int day = ((startday -1) + j) % 7;
                if(day == 5 || day == 6) continue;
                
                //출근 제대로했는지 체크
                int chulgunLimit = schedules[i] + 10;
                //10분을 더했을때 60분을 초과해서 1시간 올려줘야 하는지 체크
                int k = chulgunLimit % 100;
                if(k >= 60)  //시간을 초과했다면
                {
                    chulgunLimit -= 60;
                    chulgunLimit += 100;
                }
                if( chulgunLimit  < timelogs[i,j] )
                {
                    isSuccess = false;
                    break;
                }
            }
            if(isSuccess) answer++;
        }
        
        return answer;
    }
}