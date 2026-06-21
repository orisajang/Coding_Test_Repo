using System;
using System.Collections.Generic;

class Node
{
    public int nodeNumber {get; private set;}
    public Dictionary<int,int> dict {get; private set;} = new  Dictionary<int,int>();
    
    public Node(int num)
    {
        nodeNumber = num;
    }
    //양방향으로 서로 추가를 해야함 -> 메인에서 그냥 해주자
    public void AddNode(int nextNode, int amount)
    {
        if(dict.ContainsKey(nextNode)) 
        {
            if(dict[nextNode] > amount) dict[nextNode] = amount;
        }
        else{ dict.Add(nextNode,amount); }
    }
}

class Solution
{
    int answer = 0;
    int[] minDist;
    public int solution(int N, int[,] road, int K)
    {
        //노트 n개, road가 길, k가 시간제한
        //양방향 노드. 노드가 여러개일수있는데? 그냥 거리 작은거 쓰면 될듯?, 1번 마을에서부터 시작
        Node[] nodeArray = new Node[N+1];
        minDist = new int[N+1];
        
        for(int i=0; i< minDist.Length; i++)
        {
            minDist[i] = int.MaxValue;
        }
        
        
        for(int i=1; i<= N; i++)
        {
            Node node = new Node(i);
            nodeArray[i] = node;
        }
        //데이터를 넣어보자
        for(int i=0; i< road.GetLength(0); i++)
        {
            int startNode = road[i,0];
            int endNode = road[i,1];
            int amount = road[i,2];
            //양방향으로 추가를 서로 해주자
            nodeArray[startNode].AddNode(endNode,amount);
            nodeArray[endNode].AddNode(startNode,amount);
        }
        //탐색을 진행하자 (1번 노드부터)
        Func(nodeArray,nodeArray[1],0,K);
        
        for(int i=0; i< minDist.Length; i++)
        {
            if(minDist[i] != int.MaxValue)
            {
                answer++;
            }
        }
        
        return answer;
    }
    
    private void Func(Node[] nodeArray ,Node curNode,int curLength, int maxLength)
    {
        if(curLength > maxLength) return;
        //현재 노드에서 다음 노드까지 쭉쭉쭉 체크하면서 방문 체크
        int nodeNumber = curNode.nodeNumber;
        if(curLength >= minDist[nodeNumber]) return;
        
        minDist[nodeNumber] = curLength;
        
        //다른 노드들도 체크
        foreach(int node in curNode.dict.Keys)
        {
            //방문한적 있는지 체크
            int endNode = nodeArray[node].nodeNumber;
            int amount = curNode.dict[node];
            Func(nodeArray,nodeArray[node],curLength + amount,maxLength); 
        }
    }
}