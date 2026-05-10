using System;
using System.Linq;

public class Solution {
    public string[] solution(string[] quiz) {
        string[] answer = new string[quiz.Length];
        Console.WriteLine(quiz[0]);
        for(int i=0; i< quiz.Length; i++)
        {
            string[] strArray = quiz[i].Split(' ');
            string res = Func(strArray);
            answer[i] = res;
        }
        return answer;
    }
    private string Func(string[] strArray)
    {
        //배열을 가지고 계산을 하자
        int num1 = int.Parse(strArray[0]);
        int num2 = int.Parse(strArray[2]);
        string oper = strArray[1];
        int sum = 0;
        if(oper == "+")
        {
            sum = num1 + num2;
        }
        else
        {
            sum = num1 - num2;
        }
        //계산
        int resultNum = int.Parse(strArray[4]); 
        if( sum == resultNum)
        {
            return "O";
        }
        else
        {
            return "X";
        }
        
    }
    
}