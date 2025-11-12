using System;
using System.Text;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        StringBuilder sb = new StringBuilder();
        
        for(int i=1; i< food.Length; i++)
        {
            int div = food[i] /2;
            for(int j=0; j< div; j++)
            {
                sb.Append(i.ToString());
            }
        }
        sb.Append("0");
        for(int i=food.Length-1; i> 0; i--)
        {
            int div = food[i] /2;
            for(int j=0; j< div; j++)
            {
                sb.Append(i.ToString());
            }
        }
        answer = sb.ToString();
        return answer;
    }
}