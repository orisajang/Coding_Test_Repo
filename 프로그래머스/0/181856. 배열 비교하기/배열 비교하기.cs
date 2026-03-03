using System;

public class Solution {
    public int solution(int[] arr1, int[] arr2) {
        int answer = 0;
        if(arr1.Length == arr2.Length)
        {
            int sum1 = 0;
            int sum2 = 0;
            for(int i=0; i< arr1.Length; i++)
            {
                sum1 += arr1[i];
                sum2 += arr2[i];
            }
            if(sum1 == sum2) answer = 0;
            else
            {
                answer = (sum1 > sum2) ? 1 : -1;
            }
        }
        else
        {
            answer = (arr1.Length > arr2.Length) ? 1 : -1;
        }
        return answer;
    }
}