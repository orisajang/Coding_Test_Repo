using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        //벽이있을때 section + n 번까지 칠함
        int[] wall = new int[n]; //8이라면 0~7까지
        for(int i=0; i< section.Length; i++)
        {
            int num = section[i] -1;
            if(wall[num] == 0) //벽이 안칠해져있다면 칠함
            {
                answer++; //칠하는횟수 +1
                for(int j=0; j< m; j++) //한번 칠한다
                {   
                    if(num+j < n) //벽크기를 넘지않는다면
                    {
                        wall[num+j] = 1; 
                    }
                    else {
                        break;
                    }
                }
            }
        }
        
        return answer;
    }
}