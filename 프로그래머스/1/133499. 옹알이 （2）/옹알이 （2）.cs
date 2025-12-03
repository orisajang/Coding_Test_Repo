using System;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        //발음 가능한 단어를 설정
        string[] words = new string[] 
        {
            "aya",
            "ye",
            "woo",
            "ma"
        };
        //babbling으로 시작하는지 확인하고 시작한다면 해당 문자를 지우고
        //while문으로 계속 지워주면서 해당 배열이 다 지워졌는지 확인 ( ""인지);
        for(int i=0; i< babbling.Length; i++)
        {
            string currentWord = babbling[i];
            bool isEnd = false;
            string beforeWord = "";
            while(!isEnd)
            {
                for(int j=0; j< words.Length; j++)
                {
                    //단어로 시작했고, 이전에 지운 문자가 지금 지울문자와 같지않다면
                    if(currentWord.StartsWith(words[j]) &&
                      beforeWord != words[j])
                    {
                        //Concat있는거같은데 그냥 for문으로 문자열 잘라보자
                        string buf = "";
                        beforeWord = words[j];
                        for(int x= words[j].Length; x < currentWord.Length; x++)
                        {
                            buf += currentWord[x];
                        }
                        currentWord = buf;
                        break;
                    }
                    if(j == words.Length-1) isEnd = true;
                }
                if(currentWord == "")
                {
                    answer++;
                    isEnd = true;
                }
            }
            
        }
        
        return answer;
    }
}