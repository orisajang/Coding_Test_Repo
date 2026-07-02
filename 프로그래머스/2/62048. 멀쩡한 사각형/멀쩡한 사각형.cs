using System;

public class Solution {
    public long solution(int w, int h) {
        long answer = 0;
        //이 문제는 패턴을 파악하는 것이 중요. 8,12일 경우 2,3이 4번 나타난다.
        //기본값들 (2,3의 결과)를 딕셔너리로 계속 미리 저장해두는 것도 어렵다. 소수같은 것들도있을거임
        //그래서 가장 큰 수로 나눈 최대공배수를 이용한다
        //만약 2x2라면? 2개 사용 불가. 2개 사용가능, 만약 3x3라면? 3개 사용 불가. 6개 사용가능
        //만약 4x3라면? 6개 사용 불가. 6개 사용가능, 만약 3x4라면? 6개 사용 불가. 6개 사용가능
        //만약 5x3라면? 7개 사용 불가. 8개 사용 가능, 만약 3x5라면? 7개 사용 불가. 8개 사용 가능
        
        //8개 12개 의 GCD는? 4. 최대공약수 4로 나눈 2 3의 GCD는? 1.
        //공식을 구하면 GCD를 통해서 처리를 하면 된다.
        //공식: w+h - GCD(w,h);
        answer = ((long)w*h) -  (w+h - GCD(w,h));
        return answer;
    }
    
    private int GCD(int a, int b)
    {
        while(b != 0)
        {  
            int buf = a%b; 
            a = b; 
            b = buf; 
        }
        return a;
    }
}