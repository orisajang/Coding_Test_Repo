using System;

public class Solution {
    public string solution(string bin1, string bin2) {
        string answer = "";
        int num1 = ConvertTen(bin1);
        int num2 = ConvertTen(bin2);
        answer = ConvertTwo(num1+num2);
        
        
        return answer;
    }
    private int ConvertTen(string str)
    {
        int jari = 1;
        int sum = 0;
        for(int i=str.Length-1; i>=0; i--)
        {
            if(i != str.Length-1)
            {
                jari *= 2;
            }
            if(str[i] == '1')
            {
                sum += jari;    
            }
        }
        return sum;
    }
    private string ConvertTwo(int num)
    {
        //24 라면?
        //12 .... 0
        //6 .... 0
        //3 ....0
        //1 ....1
        if(num==0) return "0";
        
        string str = "";
        while(num > 0)
        {
            int n = num % 2;
            str = n + str;
            num /= 2;
        }
        return str;
        
    }
}