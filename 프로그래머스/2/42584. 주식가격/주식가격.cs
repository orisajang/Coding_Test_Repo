using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] prices) {
        int[] answer = new int[prices.Length];
        //이중 for문으로 언제 떨어졌는지 체크하는 방법도 있음(단, 복잡도 O(n^2))
        //그러나 규칙을 잘 살펴보면
        //계속 stack에 담아놨다가 떨어졌을때만 체크하면 됨 (O(n))
        Stack<int> st = new Stack<int>();
        
        //마지막은 무조건 0임, -1번째까지 진행하자
        for(int i=0; i< prices.Length-1; i++)
        {
            //다음에 나올 숫자가 더 작다면?
            if(prices[i] > prices[i+1])
            {
                answer[i] = 1;
                while(true)
                {
                    if(st.Count >= 1 && prices[st.Peek()] > prices[i+1])
                    {
                        int index = st.Pop();
                        answer[index] = (i+1) - index;
                    }
                    else 
                    {
                        break;
                    }
                }
            }
            else 
            {
                st.Push(i);
            }
        }
        //1,2,4번째는 안되었음
        //스택에 아직도 남아있다면
        int count = st.Count;
        for(int i=0; i< count; i++)
        {
            //남아있는거 뺀다음에 //얼마나 차이나는지 계산후 넣음
            int k = st.Pop();
            int num = (prices.Length -1) - k;
            answer[k] = num;
        }
        
        return answer;
    }
}