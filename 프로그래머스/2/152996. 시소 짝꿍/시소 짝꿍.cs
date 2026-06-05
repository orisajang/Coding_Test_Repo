using System;
using System.Collections.Generic;

public class Solution {
    public long solution(int[] weights) {
        long answer = 0;
        //핵심 아이디어: 현재 몸무게가 딕셔너리의 무게의 비율범위에 존재한다면 ++
        //오름차순 정리로 비율을 낮은거만 체크하도록 하자
        Array.Sort(weights);
        Dictionary<int,long> dict = new Dictionary<int,long>();
        
        foreach(int w in weights)
        {
            //비율별로 비교, 뒤에서 앞에 있는 것들을 추가한다
            if(dict.ContainsKey(w))
            {
                answer += dict[w];
            }
            //값이 딱 떨어지고, 딕셔너리에 존재할때만 체크
            if((w * 2) % 4 == 0 && dict.ContainsKey(w*2 / 4))
            {
                answer += dict[w*2 /4];
            }
            if((w*2) % 3 == 0 && dict.ContainsKey(w*2/3))
            {
                answer += dict[w*2/3];
            }
            if((w*3)%4 == 0 && dict.ContainsKey(w*3/4))
            {
                answer += dict[w*3/4];
            }
            //추가
            if(dict.ContainsKey(w))
            {
                dict[w]++;
            }
            else 
            {
                dict.Add(w,1);
            }
        }
        
        return answer;
    }
}