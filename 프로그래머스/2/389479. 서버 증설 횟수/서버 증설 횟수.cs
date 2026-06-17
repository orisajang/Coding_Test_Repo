using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] players, int m, int k) {
        //시간마다 계속 서버 갯수 체크. 24시간 기준
        int serverCount = 0;
        int answer = 0;
        //int[,] array = new int[24,24]; 이거로도 가능할듯?
        List<(int,int)> serverList = new List<(int,int)>();
        for(int i=0; i< players.Length; i++)
        {
            //0일때 0~1시까지의 플레이어 수
            //먼저 서버 지워야하는지부터 체크해야함
            if(serverList.Count > 0)
            {
                var (num1, num2) = serverList[0];
                if(i >= num1)
                {
                   //지울때 됨.
                    serverCount -= num2;
                    serverList.RemoveAt(0);
                }
            }
            
            int needServer = players[i] / m;
            if(needServer > serverCount)
            {
                //서버 증설 필요
                int sub = needServer - serverCount;
                serverCount += sub;
                answer += sub;
                serverList.Add((i+k,sub));
            }
        }
        
        return answer;
    }
}