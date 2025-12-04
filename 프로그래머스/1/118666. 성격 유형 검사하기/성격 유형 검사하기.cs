using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] survey, int[] choices) {
        string answer = "";
        //딕셔너리 sting,int로 각 성격별 점수를 정한다.
        //각 survey당 더해주는 점수를 그곳에 더한다
        //결과를 파악해서 대소비교를 통해 어떤 문자가 더해질지 결정한다.
        Dictionary<char,int> dic = new Dictionary<char,int>();
        //성격을 넣어준다
        dic['R'] = 0;
        dic['T'] = 0;
        dic['C'] = 0;
        dic['F'] = 0;
        dic['J'] = 0;
        dic['M'] = 0;
        dic['A'] = 0;
        dic['N'] = 0;
        //survey와 choices에 따라 점수를 더해준다
        for(int i=0; i< survey.Length;i++)
        {
            char ch1 = survey[i][0];
            char ch2 = survey[i][1];
            int addNum = 0;
            //ch1 혹은 ch2 선택
            if(1 <=  choices[i] && choices[i] <= 3 )
            {
                addNum = 4 - choices[i];
                dic[ch1] += addNum;
            }
            else if(5 <=  choices[i] && choices[i] <= 7)
            {
                //ch2 선택
                addNum = choices[i] - 4;
                dic[ch2] += addNum;
            }
        }
        //result 확인
        if(dic['R'] >= dic['T']) answer+= "R";
        else answer+= "T";
        if(dic['C'] >= dic['F']) answer+= "C";
        else answer+= "F";
        if(dic['J'] >= dic['M']) answer+= "J";
        else answer+= "M";
        if(dic['A'] >= dic['N']) answer+= "A";
        else answer+= "N";
        
        
        return answer;
    }
}