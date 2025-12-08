using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] order) {
        int answer = 0;
        //주컨테이너(que)에서는 1,2,3,4,5 .. 순으로 온다
        //보조컨테이너를 stack로 두고 숫자뺄때마다 그곳에 저장
        //order에 컨테이너에서 꺼내야할 순서가 저장되어있다.
        Stack<int> st = new Stack<int>();
        Queue<int> que = new Queue<int>();
        for(int i=0; i< order.Length; i++)
        {
            que.Enqueue(i+1); //1,2,3,4,5
        }
        
        bool isEnd = false;
        for(int i=0; i<order.Length; i++)
        {
            if(isEnd) break;
            while(true)
            {
                //보조컨테이너에 상자가 있다면?
                if(st.Count > 0 && st.Peek() == order[i])
                {
                    int j = st.Pop();
                    answer++;
                    break;
                }
                else if(que.Count > 0)
                {
                    //주컨테이너 갯수가 남아있고 맨앞이 해당상자면 가져옴
                    if(que.Peek() == order[i])
                    {
                        que.Dequeue();
                        answer++;
                        break;
                    }
                    else
                    {
                        int k = que.Dequeue();
                        st.Push(k);
                    }
                }
                else if(que.Count <= 0)
                {
                    isEnd = true;
                    break;
                }
            }
            
        }
        
        return answer;
    }
}