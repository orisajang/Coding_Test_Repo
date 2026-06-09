using System;
using System.Collections.Generic;

public class Solution {
    bool[] isVisited;
    HashSet<int> hash = new HashSet<int>();
    int answer = 0;
    public int solution(string numbers) {
        //이것도 DFS, 쭉쭉 이동하는 형식
        //숫자를 하나씩 만들어야함. 1개~n개까지 선택
        isVisited = new bool[numbers.Length];
        DFS(numbers, "");
        return answer;
    }
    private void DFS(string numbers, string current)
    {
        for(int i=0; i< numbers.Length; i++)
        {
            if(isVisited[i]) continue;
            //아니라면 한개씩 소수판별하면서 가자
            current = current + numbers[i];
            int num = int.Parse(current);
            if(!hash.Contains(num))
            {
                hash.Add(num);
                if(IsSosu(num))
                {
                    answer++;
                }
            }
            
            isVisited[i] = true;
            DFS(numbers,current);
            current = current.Substring(0, current.Length-1);
            isVisited[i] = false;
        }
    }
    
    
    private bool IsSosu(int num)
    {
        //소수인지 판별
        if(num < 2) return false;
        
        for(int i=2; i*i <= num; i++)
        {
            if(num % i == 0) 
            {
                return false;
            }
        }
        return true;
    }
}