using System;
using System.Text;

public class Solution {
    int answer = 0;
    public int solution(int n, int k) {
        StringBuilder sb = new StringBuilder();
        //진수 변환
        while(n != 0)
        {
            sb.Append(n%k);
            n /= k;
        }
        //반대로 뒤집기
        char[] array = sb.ToString().ToCharArray();
        Array.Reverse(array);
        string str = new string(array);
        //이제 조건에 맞게 체크를 해야함
        sb.Clear();
        for(int i=0; i< str.Length; i++)
        {
            if(str[i] == '0')
            {
                if(sb.Length > 0)
                {
                    CheckSosu(long.Parse(sb.ToString()));
                    sb.Clear();
                }
            }
            else
            {
                sb.Append(str[i]);
            }
        }
        if(sb.Length > 0)
        {
            //한번더 체크
            CheckSosu(long.Parse(sb.ToString()));
        }
        
        return answer;
    }
    private void CheckSosu(long num)
    {   
        if(num < 2) { return;}
        //소수 체크 (제곱근까지 체크를 했을때, 만약 나눠진 수가 없다면 소수임.)
        for(long i=2; i*i <= num; i++)
        {
            if(num % i == 0)
            {
                return;
            }
        }
        answer++;
    }
}