using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int bridge_length, int weight, int[] truck_weights) {
        int answer = 0;
        //튜플말고 int 1개로 해보자
        Queue<int> que = new Queue<int>();
        //큐에 0을 다리 갯수만큼 넣어둠. time마다 1개씩 뺄거임
        for(int i=0; i< bridge_length; i++)
        {
            que.Enqueue(0);
        }
        int index = 0;
        int time = 0;
        int curWeight = 0;
        while(index < truck_weights.Length)
        {
            time++;
            curWeight -= que.Dequeue();
            
            if(curWeight + truck_weights[index] <= weight)
            {
                que.Enqueue(truck_weights[index]);
                curWeight += truck_weights[index];
                index++;
            }
            else
            {
                que.Enqueue(0);
            }
        }
        //마지막 처리
        time += bridge_length;
        return time;
    }
}