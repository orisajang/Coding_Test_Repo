using System;
using System.Text;

public class Solution {
    public int FindMin(int a, int b)
    {
        return (a < b) ? a : b;
    }
    
    public string solution(string X, string Y) {
        string answer = "";
        StringBuilder sb = new StringBuilder();
        
        int[] countX = new int[10];
        int[] countY = new int[10];
        //각 숫자 갯수 세기
        foreach(char c in X)
        {
            countX[c - '0']++;
        }
        foreach(char c in Y)
        {
            countY[c - '0']++;
        }
        for(int i=countX.Length -1; i>= 0; i--)
        {
            if(countX[i] >0 && countY[i] >0)
            {
                int minNum = FindMin(countX[i], countY[i]);
                for(int j=0; j< minNum; j++)
                {
                    //answer += (char)(i + '0'); //string로 했는데 시간초과뜸
                    sb.Append((char)(i+'0'));
                }
            }
        }
        answer = sb.ToString();
        if(answer == "") answer = "-1";
        else if(answer[0] == '0') answer = "0";
        
        return answer;
    }
}