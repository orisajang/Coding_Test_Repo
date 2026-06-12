using System;

public class Solution {
    public int[] solution(int n) {
        //삼각형 형태의 경우 규칙이 있음. 
        //좌표로 보면 아래,오른,왼쪽위 대각 반복, 그거에 따라서 쭉쭉 가보면 된다. 
        int[,] array = new int[n,n];
        //좌표를 기억해야함. row, col, count
        int row = -1;
        int col = 0;
        int count = 1;
        //총 n이 4면 4번 하게될거임
        for(int i=0; i< n; i++)
        {
            for(int j=i; j< n; j++)
            {
                //현재 반복되고있음. 어떻게? 0번째에 아래, 1번째 오른, 2번째 대각,3번째 아래 
                if(i % 3 == 0)
                {
                    row +=1;
                }
                else if(i % 3 == 1)
                {
                    col += 1;
                }
                else
                {
                    row -=1;
                    col -=1;
                }
                array[row,col] = count++;
            }
        }
        //이제 answer에 넣기
        int[] answer = new int[count-1];
        int index = 0;
        for(int i=0; i< n; i++)
        {
            for(int j=0; j<=i; j++)
            {
                answer[index] = array[i,j];
                index++;
            }
        }
        return answer;
    }
}