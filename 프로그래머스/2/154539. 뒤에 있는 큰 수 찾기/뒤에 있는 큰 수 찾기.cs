using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = new int[numbers.Length];
        //자신보다 뒤에있는 숫자를 찾아야함
        //뒤에있는 숫자의 인덱스가 아니라 어떤 숫자인지 알아야함
        //스택에 계속 저장해뒀다가 뒤에있는 숫자가 더 크면? 하면될듯?
        //원리: numbers는 계속 작은수가 들어오다가 더 큰숫자가 들어올때만 나머지를 체크하면 되므로
        //스택에 담아서 while로 처리한다
        
        //처음 answer값을 전부 -1로 놓기(못찾을 경우 대비)
        for(int i=0; i< answer.Length; i++)
        {
            answer[i] = -1;
        }
        //뒤에있는 숫자 찾기
        Stack<int> st = new Stack<int>();
        for(int i=0; i< numbers.Length-1; i++)
        {
            //현재위치기준 다음숫자가 자신보다 클경우 스택에 담겨있는 것까지 확인
            if(numbers[i] < numbers[i+1])
            {
                answer[i] = numbers[i+1];
                //만약 스택에 뭔가 남아있고 맨위가 큰지 안큰지 체크
                while(st.Count > 0 && numbers[st.Peek()] < numbers[i+1])
                {
                    int index = st.Pop();
                    answer[index] = numbers[i+1];
                }
            }
            else
            {
                //아니라면 인덱스를 스택에 저장(인덱스를 저장해야 위치를 크기비교 가능)
                st.Push(i);
            }
        }
        
        return answer;
    }
}