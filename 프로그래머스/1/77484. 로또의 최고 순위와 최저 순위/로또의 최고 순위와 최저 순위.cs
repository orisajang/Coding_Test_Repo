using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];
        
        int max = 0;
        int min = 0;
        foreach(var item in lottos)
        {
            if(item == 0)
            {
                max++;
            }
            else if(win_nums.Contains(item)) //Linq 사용
            {
                max++;
                min++;
            }
        }
        //4개 번호 일치 3등, 2개번호일치 5등 
        //max = 4, min = 2;
        max = 7-max > 6 ? 6 : 7-max;
        min = 7-min > 6 ? 6 : 7-min;
        answer[0] = max;
        answer[1] = min;
        
        return answer;
    }
}