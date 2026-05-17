using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int lengthX = queries.GetLength(0); 
        int lengthY = queries.GetLength(1); 

        for(int i=0; i< lengthX; i++)
        {
            int min = queries[i,0];
            int max = queries[i,1];
            int multi = queries[i,2];
            
            for(int j=0; j< arr.Length; j++)
            {
                int current = arr[j];
                if(min <= j && j <= max )
                {
                    if(j % multi == 0)
                    {
                        arr[j]++;
                    }
                }
            }
        }

        return arr;
    }
}