using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(string[,] book_time) {
        int answer = 0;
        //일단 리스트에 전부 다 넣어보자. 튜플로 넣고 시간별로 정렬을 시키는거임
        List<(int start,int end)> timeList = new List<(int,int)>();
        int cleanTime = 10;
        for(int i=0; i< book_time.GetLength(0); i++)
        {
            //분단위로 변경해야함
            int min1 = ConvertTimeToMin(book_time[i,0]);
            int min2 = ConvertTimeToMin(book_time[i,1]);
            timeList.Add((min1,min2 + cleanTime));
        }
        timeList.Sort((a,b) => a.CompareTo(b));
        //이제 이 리스트를 바탕으로 시작하자
        //어떻게 하지? 맨처음 시작지점- 끝지점 기준으로 for문을 하나씩 돌리자
        //끝점에서 +10분 한 결과가 다음 시작점의 뒤에 있다면? 방 재활용
        List<(int start,int end)> useRoomList = new List<(int,int)>();
        for(int i=0; i< timeList.Count; i++)
        {
            useRoomList.Add(timeList[i]);
            for(int j=0; j< useRoomList.Count; j++)
            {
                if(useRoomList[j].end <= timeList[i].start)
                {
                    useRoomList.RemoveAt(j);
                    break;
                }
            }
            if(useRoomList.Count > answer)
            {
                answer = useRoomList.Count;
            }
        }
        return answer;
    }
    private int ConvertTimeToMin(string str)
    {
        string[] split = str.Split(':').ToArray();
        //0번째가 시간, 1번째가 분
        return (int.Parse(split[0]) * 60) + int.Parse(split[1]); 
    }
}