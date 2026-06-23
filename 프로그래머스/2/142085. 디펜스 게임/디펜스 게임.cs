using System;
using System.Collections.Generic;

public class PriorityQue
{
    //우선순위큐 (큰수) 에 대해서 구현을 해보자
    //최상위가 제일 큰 숫자를 넣어줘야함. (트리 형태를 리스트로 구현해야함. 인덱스로 층수를 구분하므로)
    List<int> treeList = new List<int>();
    public void Enqueue(int num)
    {
        treeList.Add(num);
        //부모랑 비교해서 서로 변경, 부모 0-자식 12, 부모1-자식34, 부모2-자식56, 부모3-78, 부모4-910
        //부모가 i일때 자식은 (2i + 1), (2i + 2); 
        //그렇다면? 자신위치에서의 부모인덱스는? (i-1) /2 임.
        int index = treeList.Count - 1;
        while(index > 0)
        {
            //부모 인덱스를 구하고, 크기 비교, 크다면 서로 교체해야함
            int parentIndex = (index-1) / 2;
            if(treeList[index] > treeList[parentIndex])
            {
                //서로 교체
                int buf = treeList[parentIndex];
                treeList[parentIndex] = treeList[index];
                treeList[index] = buf;
                index = parentIndex;
            }
            else
            {
                break; //끝났으니 종료시키자
            }
        }
    }
    public int Dequeue()
    {
        //최상위 부모에 있는 숫자를 return 하고, 맨 마지막 인덱스 숫자를 부모에 올린다
        //그런다음 아래 자식들 2개중에서 큰수와, 자신 숫자를 비교하면서 아래로 쭉쭉 내리기
        int returnNum = treeList[0];
        if(treeList.Count > 0)
        {
            //교체 필요
            treeList[0] = treeList[treeList.Count-1];
        }
        treeList.RemoveAt(treeList.Count-1);
        
        //현재 0번째 위치에서 하위 자식 2개를 비교. 쭉쭉 내려가보자
        int index = 0;
        while((index *2) +1 < treeList.Count )
        {
            int maxChildIndex = (index*2) +1;
            //자식이 또 존재한다면 그 자식도 비교
            if(maxChildIndex+1 < treeList.Count)
            {
                if( treeList[maxChildIndex+1] > treeList[maxChildIndex])
                {
                    maxChildIndex +=1;
                }
            }
            //최대값을 찾았으므로 현재 값과 비교해서 자식이 더 크다면 교체하자
            if(treeList[index] < treeList[maxChildIndex])
            {
                int buf = treeList[index];
                treeList[index] = treeList[maxChildIndex];
                treeList[maxChildIndex] = buf;
                index = maxChildIndex;
            }
            else
            {
                break;
            }
        }
        return returnNum;
    }
    public int Count()
    {
        return treeList.Count;
    }
    
}

public class Solution {
    public int solution(int n, int k, int[] enemy) {
        int answer = 0;
        
        //시간초과로 인해 리스트 사용 불가. 우선순위큐 구현 시도
        //List<int> countList = new List<int>();
        PriorityQue que = new PriorityQue();
        for(int i=0; i< enemy.Length; i++)
        {
            que.Enqueue(enemy[i]);
            //바로 뺄수있다면 빼자
            if(n - enemy[i] >= 0)
            {
                n-= enemy[i];
                
                answer++;
            }
            else
            {
                //아니라면? 본격적으로 k횟수를 빼서 계속 체크를 해봐야함
                while(k > 0 && n < enemy[i])
                {
                    //아니라면 저장된 수를 기준으로 계속 가보자
                    if(que.Count() > 0)
                    {
                        int max = que.Dequeue();
                        n += max;
                        k--;
                    }

                }
                //while문 끝나고나서 n이 큰상태인지 작은상태인지 체크
                if(n < enemy[i]){ break; }
                n -= enemy[i];
                answer++;
            }
        }
        return answer;
    }
}