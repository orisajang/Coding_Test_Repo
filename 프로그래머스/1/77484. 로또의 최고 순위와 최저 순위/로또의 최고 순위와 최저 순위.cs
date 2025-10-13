using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];
        int[] grade = new int[7] {
          6,6,5,4,3,2,1  
        };
        int count = 0;
        for(int i=0; i< lottos.Length; i++) //로또번호 하나씩 확인
        {
            if(lottos[i] == 0) continue;
            for(int j=0; j<win_nums.Length; j++)
            {
                if(lottos[i] == win_nums[j])
                {
                    win_nums[j] = -1; //한번 쓴 번호니까 -1로 바꿈
                    count++;
                    break;
                }
            }
        }
        answer[1] = grade[count];
        //0인것들 예외처리
        for(int i=0; i< lottos.Length; i++) //로또번호 하나씩 확인
        {
            if(lottos[i] != 0) continue; //0인거만 확인
            for(int j=0; j<win_nums.Length; j++)
            {
                if(win_nums[j] != -1)
                {
                    win_nums[j] = -1;
                    count++;
                    break;
                }
            }
        }
        answer[0] = grade[count];
        return answer;
    }
}