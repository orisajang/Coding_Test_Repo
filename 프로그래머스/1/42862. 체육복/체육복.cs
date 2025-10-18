using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = 0;
        //여벌 체육복 (reserve) 가 있는 학생만 빌려줄 수 있음
        //여벌 체육복 (reserve) 가 있고 도난당한 학생은 여벌체육복을 사용
        
        //체육복 정보 넣기
        int[] lostArray = new int[n]; //체육복 정보
        int[] reserveArray = new int[n];
        for(int i=0; i< lost.Length; i++) //체육복 잃어버린 정보 넣기
        {
            int num = lost[i] -1;
            lostArray[num] = 1; //잃어버림
        }
        for(int i=0; i< reserve.Length; i++)
        {
            int num = reserve[i] -1;
            reserveArray[num] = 1; //여분있음
        }
        //잃어버린사람이 여분있으면 잃어버리지않았다고 체크
        for(int i=0; i< reserve.Length; i++)
        {
            int num = reserve[i] -1; // 1,3,5
            if(lostArray[num] == 1)
            {
                lostArray[num] = 0;
                reserveArray[num] = 0;
            }
        }
        //잃어버린사람이 빌릴 수 있는지 확인
        for(int i=0; i< lostArray.Length; i++)
        {
            if(lostArray[i] == 1) //잃어버렸다면
            {
                //1. 이전학생한테 여분있는지 확인
                if(i>0 && reserveArray[i-1] == 1)
                {
                    reserveArray[i-1] = 0;
                    lostArray[i] = 0;
                }
                //2. 다음학생한테 여분있는지 확인
                else if(i+1 < lostArray.Length && reserveArray[i+1] == 1)
                {
                    reserveArray[i+1] = 0;
                    lostArray[i] = 0;
                }
            }
        }
        
        for(int i=0; i< lostArray.Length; i++) //전체 체육복있는 학생 확인
        {
            if(lostArray[i] == 0) answer++;
        }
        
        return answer;
    }
}