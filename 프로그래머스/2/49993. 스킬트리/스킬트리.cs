using System;

public class Solution {
    public int solution(string skill, string[] skill_trees) {
        int answer = 0;
        //스킬트리, C가오기전까지 BD가 오면 안됨
        //CBD가 없으면 다 지워볼까?
        //[0]번째가 C인지? [1]번째가B인지? 체크하자
        //전체 스킬을 돌면서
        for(int i=0; i< skill_trees.Length; i++)
        {
            string buf = "";
            for(int j=0; j< skill_trees[i].Length; j++)
            {
                //스킬에 해당 string이 존재하면 buf에 저장해준다
                if(skill.Contains(skill_trees[i][j]))
                {
                    buf += skill_trees[i][j];
                }
            }
            bool isPossible = true;
            for(int k=0; k< buf.Length; k++)
            {
                //각각의 인덱스가 맞지않으면 false
                if(buf[k] != skill[k]) 
                {
                    isPossible = false;
                    break;
                }
            }
            //다맞으면 true
            if(isPossible) answer++;
        }
        
        return answer;
    }
}