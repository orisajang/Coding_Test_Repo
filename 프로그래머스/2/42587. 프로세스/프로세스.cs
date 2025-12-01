using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] priorities, int location) {
        int answer = 0;
        //튜플을 이용해서 처리한다
        //하나를 꺼낸다음 최대 우선순위인지 확인, 아니라면 큐에 다시넣음
        //최대이고, location과 위치가 같다면 반환
        Queue<(int,int)> q = new Queue<(int,int)>();
        
        //튜플에 값을 넣는다
        for(int i=0; i< priorities.Length; i++)
        {
            q.Enqueue((i,priorities[i]));
        }
        //판단을 한다
        while(true)
        {
            //하나 뺀다
            var cur = q.Dequeue();
            int max = cur.Item2;
            //최대 판단
            foreach(var item in q)
            {
                if(max < item.Item2)
                {
                    max = item.Item2;
                }
            }
            if(max != cur.Item2)
            {
                q.Enqueue(cur);
            }
            else
            {
                answer++;
                if(cur.Item1 == location)
                {
                    return answer;
                }
            }
        }
        
        
        return answer;
    }
}