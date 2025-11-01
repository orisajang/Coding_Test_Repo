public class Solution {
    
    public int gcd(int a, int b)
    {
        while(b!= 0)
        {
            int buf = a%b;
            a = b;
            b = buf;
        }
        return a;
    }
    public int lcm (int a, int b){
        return a * b / gcd(a,b);
    }
    
    public int solution(int[] arr) {
        int answer = 0;
        int minbasu = 0;
        if(arr.Length > 1)
        {
            minbasu = lcm(arr[0],arr[1]); // 최소 공배수 저장
            for(int i=2; i< arr.Length; i++)
            {
                minbasu = lcm(minbasu,arr[i]);
            }
        }
        return minbasu;
    }
}