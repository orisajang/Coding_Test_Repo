public class Solution {
    public int solution(int n) {
        int answer = 0;
        //소수는 제곱근까지 for문 돌리면 됨
        for(int i=2; i<= n; i++)
        {
            bool isSosu = true;
            for(int j=2; (j*j) <=i; j++)
            {
                if(i %j == 0)
                {
                    isSosu = false;
                    break;
                }
            }
            if(isSosu) answer++;
        }
        
        return answer;
    }
}