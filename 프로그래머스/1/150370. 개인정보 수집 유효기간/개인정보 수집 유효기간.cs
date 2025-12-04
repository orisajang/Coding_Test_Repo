using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
        List<int> list = new List<int>();
        Dictionary<string,int> dic = new Dictionary<string,int>();
        //약관종류 저장
        for(int i=0; i< terms.Length; i++)
        {
            string[] ss = terms[i].Split(" ");
            dic[ss[0]] = int.Parse(ss[1]);
        }
        //날짜가 지났는지 확인하는 로직
        for(int i=0; i< privacies.Length; i++)
        {
            //날짜와 약정기간으로 나눔
            string[] ss = privacies[i].Split(" ");
            //년,월,일 로 나눔
            string[] date = ss[0].Split(".");
            string[] todayDate = today.Split(".");
            //숫자 비교해줘야되니까 int로 Parse
            int[] dateInt = new int[date.Length];
            int[] todayInt = new int[todayDate.Length];
            for(int j=0; j< dateInt.Length; j++)
            {
                dateInt[j] = int.Parse(date[j]);
                todayInt[j] = int.Parse(todayDate[j]);
            }
            
            dateInt[1] += dic[ss[1]]; //월에 약정 기간을 더한다
            //월이 12를 넘는다면
            //if(dateInt[1] > 12) 
            {
                dateInt[0] += ((dateInt[1]-1) / 12); //년에 더해줌
                dateInt[1] = ((dateInt[1]-1) % 12) +1; //월을 다시계산
            }
            //일도 -1 해준다
            dateInt[2] -=1;
            if(dateInt[2] <= 0)
            {
                dateInt[2] = 28;
                dateInt[1] -=1;
                if(dateInt[1] <= 0)
                {
                    dateInt[1] = 12;
                    dateInt[0] -= 1;
                }
            }
            
            // 오늘날짜기준으로 지워야하는 개인정보인지 확인
            //년 비교
            if(todayInt[0] > dateInt[0]) list.Add(i+1);
            else if(todayInt[0] == dateInt[0])
            {
                //월 비교
                if(todayInt[1] > dateInt[1]) list.Add(i+1);
                else if(todayInt[1] == dateInt[1])
                {
                    //일 비교
                    if(todayInt[2] > dateInt[2]) list.Add(i+1);
                }
            }
        }
        
        int[] answer = list.ToArray();
        return answer;
    }
}