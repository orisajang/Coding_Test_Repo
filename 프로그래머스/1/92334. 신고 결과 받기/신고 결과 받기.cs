using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
        //각 유저별로 신고는 1번씩 할 수 있음
        //어떤 유저가 누구를 신고했는지 알아야함
        int[] answer = new int[id_list.Length];
        Dictionary<string,int> reportCountDict = new Dictionary<string,int>();
        Dictionary<string,List<string>> nameListDict = new Dictionary<string,List<string>>();
        for(int i=0; i< id_list.Length; i++)
        {
            reportCountDict.Add(id_list[i],i);
            nameListDict.Add(id_list[i], new List<string>());
        }
        //신고당한 횟수를 센다.
        //누가 신고했는지도 string,string으로 2개를 저장해둔다.
        
        for(int i=0; i< report.Length; i++)
        {
            string[] inputArray = report[i].Split(' ');
            //신고한사람을 딕셔너리에 넣자
            if(!nameListDict[inputArray[1]].Contains(inputArray[0]))
            {
                //존재하지않다면 저장
                nameListDict[inputArray[1]].Add(inputArray[0]);
            }
        }
        //갯수를 세자
        foreach(var item in nameListDict.Keys)
        {
            if(nameListDict[item].Count >= k )
            {
                //하나씩 더해주자
                List<string> listBuf = nameListDict[item];
                for(int i=0; i< listBuf.Count; i++)
                {
                    string str = listBuf[i];
                    int index = reportCountDict[str];
                    answer[index]++;
                }
            }
        }
        
        return answer;
    }
}