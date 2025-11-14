using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
        string[] answer = new string[players.Length];
        //딕셔너리로 string과 순위 정보를 가지고있다면?
        Dictionary<string,int> dic = new Dictionary<string,int>();
        for(int i=0; i< players.Length; i++)
        {
            dic[players[i]] = i;
        }
        
        //리스트의 n번째와 n-1번째의 배열에서 서로 순위를 바꿈,
        for(int i=0; i< callings.Length; i++)
        {
            int rank = dic[callings[i]];
            //swap, 배열도바꾸고 딕셔너리도 바꿈
            //1. 딕셔너리 먼저 (순위갱신)
            int bufNum = dic[players[rank]];
            dic[players[rank]] = dic[players[rank-1]];
            dic[players[rank-1]] = bufNum;
            
            //2. 배열 (이름)
            string buf = players[rank];
            players[rank] = players[rank-1];
            players[rank-1] = buf;
        }
        
        for(int i=0; i< players.Length; i++)
        {
            answer[i] = players[i];
        }
        
        return answer;
    }
}