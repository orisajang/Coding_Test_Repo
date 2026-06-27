using System;

public class Solution {
    public int solution(int[,] data, int col, int row_begin, int row_end) {
        int answer = 0;
        //정렬을 통해서 데이터를 갱신한다. col번째 행을 기준으로.
        for(int i=0; i< data.GetLength(0); i++)
        {
            for(int j=i +1; j< data.GetLength(0); j++)
            {
                //하나씩 비교
                if(data[i,col-1] > data[j,col-1] || 
                   (data[i,col-1] == data[j,col-1] && data[i,0] < data[j,0]))
                {
                    for(int k=0; k< data.GetLength(1); k++)
                    {
                        int buf = data[i,k];
                        data[i,k] = data[j,k];
                        data[j,k] = buf;
                    }
                }
            }
        }
        //데이버 비교 완료했으므로 값을 구하자
        int mid = 0;
        for(int i=row_begin; i<= row_end; i++)
        {
            int index = i -1;
            int sum = 0;
            for(int j=0; j< data.GetLength(1); j++)
            {
                sum += data[index,j] % i;
            }
            //XOR 해보자
            mid = mid ^ sum;
        }
        return mid;
    }
}