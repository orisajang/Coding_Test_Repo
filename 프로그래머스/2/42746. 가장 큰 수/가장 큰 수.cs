using System;
using System.Text;

public class Solution {
    public string solution(int[] numbers) {
        string answer = "";
        
        string[] str = new string[numbers.Length];
        for(int i=0; i< str.Length; i++)
        {
            str[i] = numbers[i].ToString();
        }
        //정렬
        Array.Sort(str,(a,b)=> (b+a).CompareTo(a+b));
        //스트링빌더
        StringBuilder sb = new StringBuilder();
        for(int i=0; i<str.Length; i++)
        {
            sb.Append(str[i]);
        }
        answer = sb.ToString();
        if(answer[0] == '0') return "0";

        return answer;
    }
}