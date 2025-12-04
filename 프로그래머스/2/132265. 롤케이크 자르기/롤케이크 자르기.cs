using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int[] topping) {
        int answer = 0;
        //딕셔너리 2개로 오른쪽 왼쪽사람이 가지고있는 토핑개수 비교
        //오른쪽에 다 채운다음에 하나씩 왼쪽으로 넣어서 매번 전체 for문을 돌리지않게한다
        Dictionary<int,int> dicLeft = new Dictionary<int,int>();
        Dictionary<int,int> dicRight = new Dictionary<int,int>();
        //오른쪽에 다 채워준다
        for(int i=0; i< topping.Length; i++)
        {
            int curNum = topping[i];
            if(!dicRight.ContainsKey(curNum)) dicRight[curNum] = 1;
            else dicRight[curNum]++;
        }
        //이제 하나씩 빼면서 왼쪽에 채워줌 (단 전체를 훑는게아닌 1개씩 빼주면서)
        for(int i=0; i< topping.Length; i++)
        {
            //왼쪽에 1개 넣어주고 오른쪽에서는 1개 뺀다
            int curNum = topping[i];
            //왼쪽에 넣기
            if(!dicLeft.ContainsKey(curNum)) dicLeft[curNum] = 1;
            else dicLeft[curNum]++;
            //오른쪽 하나 빼기
            dicRight[curNum]--;
            if(dicRight[curNum] == 0)
            {
                dicRight.Remove(curNum);
            }
            
            if(dicLeft.Count == dicRight.Count) answer++;
        }
        
        
        return answer;
    }
}