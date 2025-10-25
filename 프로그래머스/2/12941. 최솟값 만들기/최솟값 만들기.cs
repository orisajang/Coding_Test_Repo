using System;

public class Solution {
    public int solution(int[] A, int[] B) {
        int answer = 0;
        //A배열은 최소값 정렬, B배열은 최대값 정렬하면 될듯?
        Array.Sort(A);
        Array.Sort(B);
        Array.Reverse(B);
        //각각의 수를 곱해서 더해준다
        for(int i=0; i<A.Length; i++)
        {
            answer += A[i] * B[i];
        }
        
        return answer;
    }
}