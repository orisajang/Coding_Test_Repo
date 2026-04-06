using System;

public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        //행렬의 곱셈 하는방법:
        // 1 4      
        // 3 2      3 3
        // 4 1      3 3
        int lengthX = arr1.GetLength(0);
        int lengthY = arr1.GetLength(1);
        int arr2Length = arr2.GetLength(1);
        int[,] answer = new int[lengthX,arr2Length];
        
        for(int row=0; row < lengthX; row++)
        {
            for(int col=0; col < arr2Length; col++)
            {
                int sum = 0;
                for(int y=0; y < lengthY; y++)
                {
                    sum += (arr1[row,y] * arr2[y,col]);
                }
                answer[row,col] = sum;
            }
        }
        return answer;
    }
}