using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] queue1, int[] queue2) {
        int answer = -1;
        //한쪽은 빼는역할, 한쪽은 받는역할로. 하자. 
        //먼저 queue1에서 빼서 queue2에 넣도록 진행 -> 크면? queue1에 넣고 +1하고 계속하면됨
        //일단 두 원소의 합을 확인해야함
        answer = Func(queue1, queue2);
        return answer;
    }
    private int Func(int[] queue1, int[] queue2)
    {
        int answer = -1;
        //일단 두 원소의 합을 확인해야함
        long sum1 = 0;
        long sum2 = 0;
        long average = 0;
        Queue<int> que1 = new Queue<int>();
        Queue<int> que2 = new Queue<int>();
        for(int i=0; i< queue1.Length; i++)
        {
            sum1 += queue1[i];
            sum2 += queue2[i];
            que1.Enqueue(queue1[i]);
            que2.Enqueue(queue2[i]);
        }
        if((sum1 + sum2) % 2 != 0)
        {
            return -1;
        }
        //평균은?
        average = (sum1 + sum2) /2;
        int count =0;
        while(count <= queue1.Length*3)
        {
            while(sum1 > average)
            {
                count++;
                int numBuf = que1.Dequeue();
                que2.Enqueue(numBuf);
                sum2 += numBuf;
                sum1 -= numBuf;
            }
            if(sum1 == average)
            {
                answer = count;
                break;
            }
            //더해주자
            count++;
            int addNum = que2.Dequeue();
            que1.Enqueue(addNum);
            sum1 += addNum;
        }
        return answer;
    }
} 