using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        string answer = "";
        
        //cards1과 cards2 에서 0번째 인덱스값이 goal이라면 OK, 아니라면 false
        //1.일단 queue에 string을 넣는다
        Queue<string> que1 = new Queue<string>();
        Queue<string> que2 = new Queue<string>();
        int count = goal.Length;
        for(int i=0; i<cards1.Length; i++)
        {
            que1.Enqueue(cards1[i]);
        }
        for(int i=0; i<cards2.Length; i++)
        {
            que2.Enqueue(cards2[i]);
        }
        
        //2.queue에 들어있는 값들이 둘중하나가 맞는지 확인
        for(int i=0; i< count; i++)
        {
            int len1 = que1.Count;
            int len2 = que2.Count;
            
            if(len1 >0 && len2 > 0)
            {
                if(que1.Peek() == goal[i])
                {
                    que1.Dequeue();
                }
                else if(que2.Peek() == goal[i])
                {
                    que2.Dequeue();
                }
                else 
                {
                    return "No";
                }
            }
            else if(len1 > 0)
            {
                if(que1.Peek() == goal[i]){
                    que1.Dequeue();
                }
                else {
                    return "No";
                }
            }
            else if(len2 >0)
            {
                if(que2.Peek() == goal[i]){
                    que2.Dequeue();
                }
                else{
                    return "No";
                }
            }
        }
        
        return "Yes";
        //return answer;
    }
}