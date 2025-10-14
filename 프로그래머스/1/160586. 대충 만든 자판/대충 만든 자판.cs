using System;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int length = targets.Length; //2
        int[] answer = new int[length];
        int[] alpabet = new int[26];
        //A~Z까지 26개 알파벳 있음
        //for문 돌면서 alpabet에 이미 값이 존재하는지 확인 (0인지)
        //끝나면 targets에서 target의 갯수만큼 for문 돌려서 answer에 넣어줌
        int max = keymap[0].Length;
        for(int i=1; i<keymap.Length; i++)
        {
            if(max < keymap[i].Length) max = keymap[i].Length;
        }
        for(int j=0; j<max; j++)
        {
            for(int i=0; i<keymap.Length; i++)
            {
                if(keymap[i].Length > j)
                {
                    int a1 = keymap[i][j] - 'A';
                    if(alpabet[a1] == 0)
                    {
                        alpabet[a1] = j+1;
                    }
                }
            }
        }
        //target 갯수만큼 for문
        for(int i=0; i< targets.Length; i++)
        {
            int count = 0;
            for(int j=0; j< targets[i].Length; j++)
            {
                int a3 = targets[i][j] - 'A';
                if(alpabet[a3] == 0) //keymap에 존재하지 않았다면
                {
                    count = -1;
                    break;
                }
                else //값이 존재한다면
                {
                    count += alpabet[a3];
                }
            }
            answer[i] = count;
        }
        
        
        return answer;
    }
}