using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] answers) {
        //int[] answer = new int[3];
        //1번 1~5
        //2번 21232425
        //3번 3311224455
        int[] people1 = new int[]{1,2,3,4,5}; //찍는 방법 배열
        int[] people2 = new int[]{2,1,2,3,2,4,2,5};
        int[] people3 = new int[]{3,3,1,1,2,2,4,4,5,5};
        int length1 = people1.Length; //5  (배열갯수)
        int length2 = people2.Length; //8
        int length3 = people3.Length; //10
        int[] count = new int[3]; //정답 맞춘횟수
        
        //answers.Length개까지 for문
        for(int i=0; i<answers.Length; i++)
        {
            if(people1[i%length1] == answers[i]) count[0]++;
            if(people2[i%length2] == answers[i]) count[1]++;
            if(people3[i%length3] == answers[i]) count[2]++;
        }
        
        //최대값 확인 
        List<int> array = new List<int>();
        int max = count[0];
        for(int i=0; i< 3; i++)
        {
            if(max == count[i])
            {
                array.Add(i+1);
            }
            else if(max < count[i])
            {
                max = count[i];
                array.Clear();
                array.Add(i+1);
            }
        }
        //answer 배열 형식에 맞게 추가
        int[] answer = array.ToArray();
        return answer;
    }
}