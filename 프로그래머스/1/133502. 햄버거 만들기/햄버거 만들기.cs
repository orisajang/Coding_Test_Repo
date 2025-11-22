using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] ingredient) {
        int answer = 0;
        List<int> listStack = new List<int>();
        
        foreach(int ingre in ingredient)
        {
            listStack.Add(ingre);
            
            if(listStack.Count >= 4)
            {
                int n = listStack.Count;
                if(listStack[n-4] == 1 &&
                  listStack[n-3] == 2 &&
                  listStack[n-2] == 3 &&
                  listStack[n-1] == 1)
                {
                    answer++;
                    listStack.RemoveRange(n-4,4);
                }
            }
            
        }
        
        return answer;
    }
}