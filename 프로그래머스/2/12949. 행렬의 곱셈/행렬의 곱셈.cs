using System;

public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        int lengthX = arr1.GetLength(0);
        int lengthY = arr1.GetLength(1);
        int answerY = arr2.GetLength(1);
        int[,] answer = new int[lengthX, answerY];
        
        for(int i=0; i< lengthX; i++)
        {
            //arr2에서 돌아야함
            for(int y=0; y < arr2.GetLength(1); y++)
            {
                int sum = 0;
                for(int x=0; x<arr2.GetLength(0); x++)
                {
                    //arr1은??
                    sum +=  (arr1[i, x] * arr2[x, y]);
                }
                answer[i, y] = sum;
            }
        }
        return answer;
    }
}