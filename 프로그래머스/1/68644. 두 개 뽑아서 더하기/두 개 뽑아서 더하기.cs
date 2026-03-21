using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        HashSet<int> hash = new HashSet<int>();
        List<int> sumList = new List<int>();
        for(int i=0; i< numbers.Length; i++)
        {
            for(int j=i+1; j< numbers.Length; j++)
            {
                int sum = numbers[i] + numbers[j];
                if(!hash.Contains(sum))
                {
                    hash.Add(sum);
                    sumList.Add(sum);
                }
            }
        }
        sumList.Sort();
        
        int[] answer = new int[sumList.Count];
        for(int i=0; i< sumList.Count; i++)
        {
            answer[i] = sumList[i];
        }
        return answer;
    }
}