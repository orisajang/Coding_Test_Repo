using System;
using System.Text;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[2];
        //s가 1이 될때까지. 
        //이진 변환의 횟수,
        //제거된 0의 개수
        int calcCount = 0;
        int deleteZeroCount = 0;
        
        while(s != "1")
        {
            calcCount++;
            //x의 모든 0을 제거
            StringBuilder sb = new StringBuilder();
            int oneCount = 0;
            for(int i=0; i<s.Length; i++)
            {
                if(s[i] == '1') oneCount++;
                else if(s[i] =='0') deleteZeroCount++;
            }
            //1의 횟수가 4이므로 4를 이진수로
            string str = "";
            while(oneCount >0)
            {
                int namerji = oneCount % 2;
                str = namerji + str;
                oneCount /=2;
            }
            s = str;
        }
        
        answer[0] = calcCount;
        answer[1] = deleteZeroCount;
        
        
        
        return answer;
        
    }
}