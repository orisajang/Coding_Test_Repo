using System;
using System.Linq;
public class Solution {
    public string solution(string s) {
        string answer = "";
        char[]ch = s.ToCharArray();
        Array.Sort(ch);
        Array.Reverse(ch);
        answer = new string(ch);
        return answer;
    }
}