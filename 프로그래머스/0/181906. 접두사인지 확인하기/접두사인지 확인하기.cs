using System;

public class Solution {
    public int solution(string my_string, string is_prefix) {
        int answer = 0;
        int checkIndex = 0;
        int maxIndex = is_prefix.Length; //3
        for(int i=0; i<my_string.Length; i++)
        {
            if(my_string[i] == is_prefix[checkIndex])
            {
                checkIndex++;
            }
            else{
                checkIndex = 0;
                break; //한번이라도 틀리면끝
            }
            
            if(checkIndex == maxIndex) 
            {
                answer = 1;
                break;
            }
        }

        return answer;
    }
}