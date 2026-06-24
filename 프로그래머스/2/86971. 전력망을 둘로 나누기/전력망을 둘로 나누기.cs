using System;
using System.Collections.Generic;

public class Solution {
    Dictionary<int,List<int>> dict = new Dictionary<int,List<int>>();
    public int solution(int n, int[,] wires) {
        int answer = 0;
        //선 중복체크는 어떻게 하지? 아 7번하고 3번을 끊을거니까 3번과 7번기준에서
        //클래스 따로 만들어서 처리하는 방법, 딕셔너리<int,List<int>> 있을듯
        for(int i=0; i< wires.GetLength(0); i++)
        {
            for(int j=0; j< wires.GetLength(1); j++)
            {
                int num = wires[i,j];
                if(!dict.ContainsKey(num))
                {
                    dict.Add(num,new List<int>());
                }
            }
            dict[wires[i,0]].Add(wires[i,1]);
            dict[wires[i,1]].Add(wires[i,0]);
        }
        int minDiff = int.MaxValue;
        
        //딕셔너리에 정보가 있으므로 이제 하나씩 끊어보자.
        for(int i=0; i< wires.GetLength(0); i++)
        {
            int num1 = wires[i,0];
            int num2 = wires[i,1];
            //두개의 연결을 끊고나서 연결된 모든 숫자를 확인해야하는데?
            int res1 = Func(num1,num2, new HashSet<int>());
            int res2 = n - res1;
            int diff = (res1 - res2);
            if(diff < 0) diff *= -1;
            if(diff < minDiff)
            {
                minDiff = diff;
            }
        }
        return minDiff;
    }
    private int Func(int selectedNum, int subNum, HashSet<int> hash)
    {
        //리스트에서 하나씩 더하면서 쭉쭉 가보자
        //현재 노드에서 다른 노드와 어떻게 연결되었는지 정보가 list에 있다.
        //subNum을 만나면 무시하고, 중복으로 addList를 만나도 무시하자.
        //자신 인접 노드를 만나면? 추가 and 무시? HashSet?
        hash.Add(selectedNum);
        List<int> list = dict[selectedNum];
        for(int i=0; i< list.Count; i++)
        {
            int num = list[i];
            if(num == subNum) continue;
            if(hash.Contains(num)) continue;
            hash.Add(num);
            //근데 여기서? 다른 노드도 체크해보자
            Func(num,subNum,hash);
        }
        return hash.Count;
    }
    
}