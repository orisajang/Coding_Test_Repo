using System;

public class Solution {
    public int[] solution(int[] sequence, int k) {
        int[] answer = new int[2];
        answer[0] = 0;
        answer[1] = sequence.Length-1;
        //뒤에서 부터 하자. 단, 만약에 앞에있는 숫자가 같은 숫자이면? 따로 처리해야함
        int start = 0;
        int end = sequence.Length-1;
        int sum = 0;
        for(int i= 0; i < sequence.Length; i++)
        {
            end = i;
            
            sum += sequence[i];
            while(sum > k)
            {
                //sum이 커졌다면? 마지막 숫자를 지우자
                sum -= sequence[start];
                start++;
            }
            //정답 찾음
            if(sum == k)
            {
                if(end-start < answer[1] - answer[0])
                {
                    //이거 어떻게 하지
                    answer[0] = start;
                    answer[1] = end;
                }
            }
            
        }
        
        //결과 출력하기
        return answer;
    }
}