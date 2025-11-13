using System;
using System.Text;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        StringBuilder sb = new StringBuilder();
        //3진법 변환후 반전
        while(n != 0)
        {
            int namerji = n % 3;
            sb.Append(namerji.ToString());
            n /= 3;   
        }
        //10진법으로 표현
        int multiPoint = 1;
        string str = sb.ToString();
        for(int i=str.Length-1; i>= 0; i--)
        {
            int num = str[i] - '0';
            answer += (num * multiPoint);
            multiPoint *=3;
        }
        
        return answer;
    }
}