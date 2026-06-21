using System;
using System.Collections.Generic;

class Solution
{
    public int solution(int N, int[,] road, int K)
    {
        int answer = 0;
        //Queue로 시도해보자
        int[] bCost = new int[N+1];
        for(int i=0; i<= N; i++)
        {
            if(i==1) bCost[i] = 0;
            else bCost[i] = int.MaxValue;
        }
        Queue<int> que = new Queue<int>();
        que.Enqueue(1);
        while(que.Count > 0)
        {
            int curNode = que.Dequeue();
            for(int i=0; i< road.GetLength(0); i++)
            {
                int start = road[i,0];
                int end = road[i,1];
                int cost = road[i,2];
                if(start == curNode)
                {
                    //end노드에서의 최소값을 건들자
                    if(bCost[end] > bCost[curNode] + cost)
                    {
                        bCost[end] = bCost[curNode] + cost;
                        que.Enqueue(end);
                    }
                }
                else if(end == curNode)
                {
                    if(bCost[start] > bCost[curNode] + cost)
                    {
                        bCost[start] = bCost[curNode] + cost;
                        que.Enqueue(start);
                    }
                }
            }
        }
        //값이 바뀐 노드로 갯수 탐색
        for(int i=0; i< bCost.Length; i++)
        {
            if(bCost[i] <= K)
            {
                answer++;
            }
        }
        return answer;
    }
}