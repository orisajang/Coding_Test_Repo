using System;

public class Solution {
    public bool FindMaxAndMinNumberCount(int number, int[] array)
    {
        int maxCount = 0;
        int minCount = 0;
        //0,1,3,5,6
        for(int i=0; i< array.Length; i++)
        {
            if(number <= array[i])
            {
                maxCount = array.Length-i;
                minCount = i;
                
                if(number == array[i]) minCount++;
                break;
            }
        }
        if(maxCount >= number && minCount <= number)
        {
            return true;
        }
        else return false;
        
    }
    public int solution(int[] citations) {
        int answer = 0;
        //정답을 찾았지만 최대 H-index를 찾아야할때 플래그
        bool isFindMax = false;
        
        //정렬 한번 하기.
        Array.Sort(citations);
        bool isFind = false;
        for(int i=0; i<= citations.Length; i++)
        {
            
            isFind = FindMaxAndMinNumberCount(i,citations);
            if(isFind)
            {
                answer = i;
            }
        }
        
        
        return answer;
    }
}