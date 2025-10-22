
using System;
using System.Collections.Generic;
public class Solution {

    int FindMax(int a, int b)
    {
        return (a>b) ? a : b; 
    }
    int FindMin(int a, int b)
    {
        return (a<b) ? a : b; 
    }
    public string solution(string s) 
    {
        string answer = "";

        List<int> numList = new List<int>(); 
        string str = "";    //stringBuilder로 바꿔보기
        for(int i=0; i<s.Length; i++)
        {
            if(s[i] == ' ') //공백을 만나면 반환
            {
                int numBuf = int.Parse(str);
                numList.Add(numBuf);
                str = "";
            } 
            else{
                str+= s[i];
            }
        }
        if(str != "") //마지막 처리,str에 뭔가 남아있으면 그거를 변환
        {
            int buf2 = int.Parse(str);
            numList.Add(buf2);
            str = "";
        }
        // 최소 최대값 변환을 함
        int max = numList[0];
        int min = numList[0];
        for(int i=0; i< numList.Count; i++)
        {
            max = FindMax(max, numList[i]);
            min = FindMin(min, numList[i]);
        }
        answer = min + " " + max;

        return answer;
    }
}