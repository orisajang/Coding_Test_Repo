using System;
using System.Collections.Generic;
public class Solution {
    List<string> strList = new List<string>();
    //아 이거 20 이런 숫자도 포함이라 그게 안됨. 저장을 어떻게 할까?
    List<int[]> huboList = new List<int[]>();
    int colLength = 0;
    public int solution(int n, int[,] q, int[] ans) {
        int answer = 0;
        colLength = q.GetLength(1); //5
        //일단 모든 가능한 숫자를 찾아보자 (DFS가 맞는듯)
        Func(new List<int>(), n, 1);
        //이제 후보군중에서 조건에 맞는지 체크해보자
        for(int i=0; i< huboList.Count; i++)
        {
            int[] array = huboList[i];
            bool isTrue = true;
            for(int row=0; row< q.GetLength(0); row++)
            {
                int count = 0;
                for(int col =0; col< q.GetLength(1); col++)
                {
                    //돌려버리자
                    for(int j=0; j < array.Length; j++)
                    {
                        if(array[j] == q[row,col])
                        {
                            count++;
                            break;
                        }
                    }
                }
                //한번 돌렸으면 체크를 하자 실제 맞는지
                if(ans[row] != count)
                {
                    isTrue = false;
                    break;
                }
            }
            if(isTrue)
            {
                answer++;
            }
        }
        return answer;
    }
    
    private void Func(List<int> list, int n, int start)
    {
        //colLength는 매번 5가 됨 
        if(list.Count >= colLength)
        {
            //하나씩 기록
            int[] array = new int[list.Count];
            for(int i=0; i< list.Count; i++)
            {
                array[i] = list[i];
            }
            huboList.Add(array);
            return;
        }
        //아니라면 계속 하나씩 쌓아줘야함
        for(int i=start; i<= n; i++)
        {
            list.Add(i);
            Func(list,n, i+1);
            list.RemoveAt(list.Count-1);
        }
    }
    
}