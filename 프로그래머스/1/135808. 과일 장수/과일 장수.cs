using System;
public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        Array.Sort(score); //정렬(오름차순)
        Array.Reverse(score); //내림차순으로 변경 (반전)
        int loopCount = score.Length / m; //상자 갯수
        for(int i=0; i< loopCount; i++)
        {
            int endPos = ((i+1)* m) -1; //0, 4, 8 ... 0123,4567,891011
            //for문 필요없음 그냥 -1번째를 찾으면 된다.. 3,7,11 번째
            answer += score[endPos] * m;
        }
        return answer;
    }
}