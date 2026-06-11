using System;

public class Solution {
    char[] moum = new char[] {'A', 'E', 'I', 'O', 'U'};
    int count = 0;
    bool isFind = false;
    public int solution(string word) {
        int answer = 0;
        
        DFS(word, "");
        
        return count;
    }
    private void DFS(string word ,string str)
    {
        if(str.Length >= 5) return;
        
        
        for(int i=0; i< moum.Length; i++)
        {
            if(isFind) return;
            //하나씩 더하자 
            count++;
            if(str + moum[i] == word)
            {
                isFind = true;
                return;
            }
            DFS(word, str + moum[i]);
        }
    }
}