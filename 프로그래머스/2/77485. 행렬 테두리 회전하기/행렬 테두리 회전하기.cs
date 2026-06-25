using System;

public class Solution {
    public int[] solution(int rows, int columns, int[,] queries) {
        //원본 배열을 가지고 그냥 돌린다고 생각해보자. (자른 배열을 따로 만드니까 좌표 관리가 힘듬)
        int[] answer = new int[queries.GetLength(0)];
        //데이터 생성
        int count = 1;
        int[,] array = new int[rows,columns];
        for(int row = 0; row < rows; row++)
        {
            for(int col = 0; col < columns; col++)
            {
                array[row,col] = count++;
            }
        }
        //이제 for문 돌리면서 최소값구하고, 배열 회전시켜보자
        //아이디어: 원형배열처럼 다 돌려버리기
        for(int i=0; i< queries.GetLength(0); i++)
        {
            int startX = queries[i,0] -1; //1
            int startY = queries[i,1] -1; //1
            int endX = queries[i,2] -1; // 4
            int endY = queries[i,3] -1; // 3
            // 좌표 기준은 -1임 
            int temp = array[startX,startY];
            int min = temp;
            //for문 4개로 차례로 돌려보자
            //왼쪽
            for(int row = startX; row < endX; row++)
            {
                //+1한거 가져오기
                array[row,startY] = array[row+1,startY];
                if(min > array[row+1,startY]) 
                {
                    min = array[row+1,startY];
                }
            }
            //아래
            for(int col = startY; col < endY; col++)
            {
                array[endX,col] = array[endX,col+1];
                if(min > array[endX,col+1])
                {
                    min = array[endX,col+1];
                }
            }
            //오른쪽
            for(int row = endX; row > startX; row--)
            {
                array[row,endY] = array[row-1,endY];
                if(min > array[row-1,endY])
                {
                    min = array[row-1,endY];
                }
            }
            //위쪽
            for(int col = endY; col > startY; col--)
            {
                array[startX,col] = array[startX,col-1];
                if(min > array[startX,col-1])
                {
                    min = array[startX,col-1];
                }
            }
            //하나는 따로 채워줘야함
            array[startX,startY+1] = temp;
            answer[i] = min;
        }
        
        return answer;
    }
}