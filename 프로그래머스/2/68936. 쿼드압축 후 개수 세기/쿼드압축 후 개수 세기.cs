using System;

public class Solution {
    int[] answer;
    public int[] solution(int[,] arr) {
        // 8*8 = 64, for문으로 쭉쭉이동하면서 다르면 바로 4개로 나누기
        // 4*4의 4개로 나누기, 2*2의 8개로 나누기, 1*1 로 다시 나누면 됨
        answer = new int[2];
        int lineLength = arr.GetLength(0);
        Func(arr,0,0,lineLength);
        return answer;
    }
    private void Func(int[,] arr, int startX, int startY, int length)
    {
        int startNumber = arr[startX,startY];
        bool isSame = true;
        for(int row=startX; row < startX+ length; row++)
        {
            for(int col = startY; col < startY + length; col++)
            {
                if(arr[row,col] != startNumber)
                {
                    isSame = false;
                    break;
                }
            }
            if(!isSame) break;
        }
        if(isSame)
        {
            //결과에 ++해주기
            answer[startNumber]++;
        }
        else
        {
            //4개로 나누어서 쭈쭉 다시 진행하도록 하자
            int half = length /2;
            Func(arr,startX, startY, half);
            Func(arr,startX+half, startY, half);
            Func(arr,startX, startY + half, half);
            Func(arr,startX+half, startY+half, half);
        }
    }
    
    
}