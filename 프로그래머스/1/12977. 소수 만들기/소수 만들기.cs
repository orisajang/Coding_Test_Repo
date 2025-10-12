using System;

class Solution
{
    public bool bSosu(int number)
    {
        //소수인지 파악하는방법 (나눠지는 수가 1과 자기자신이어야한다.)
        for(int i=2; i<number; i++)
        {
            if(number % i == 0 ) return false;
        }
        return true;
    }
    
    public int solution(int[] nums)
    {
        int answer = 0;
        
        for (int i = 0; i < nums.Length-2; i++) 
        {
            for (int j = i + 1; j < nums.Length - 1; j++) 
            {
                //i가 0일때 j는 1,2
                //i가 1일때 j는 2
                for (int k = j + 1; k < nums.Length; k++)
                {
                    //i가0일때 j는1, k는 2,3
                    //i가0, j는2, k는 3
                    //i가1일때, j는2, k는3 끝
                    //Console.WriteLine($"[{nums[i]},{nums[j]},{nums[k]}]"); //출력
                    int number = nums[i]+nums[j]+nums[k];
                    if(bSosu(number)) answer++;
                }
            }
        }
        
        return answer;
    }
}