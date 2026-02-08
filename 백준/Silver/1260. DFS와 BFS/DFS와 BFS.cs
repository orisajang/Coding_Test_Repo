using System;
using System.Collections.Generic;
using System.Linq;

namespace back1260
{
    class Node
    {
        public List<int> connectNodeNum = new List<int>();
        public void AddNode(int conNodeNum)
        {
            connectNodeNum.Add(conNodeNum);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //DFS와 BFS로 탐색한 결과를 반환
            //BFS -> 가장 최근것들을 탐색
            //DFS -> 한쪽으로 끝까지 탐색
            
            //1. 입력부터 받자
            string[] str = Console.ReadLine().Split(' ').ToArray();
            int n = int.Parse(str[0]);
            int m = int.Parse(str[1]);
            int v = int.Parse(str[2]);
            
            Node[] nodeArray = new Node[n+1];
            for(int i=0; i< nodeArray.Length; i++)
            {
                nodeArray[i] = new Node();
            }
            //2. 그래프의 연결 방향이 어떻게 나있는지.
            for(int i=0; i<m; i++)
            {
                string[] nodeStr = Console.ReadLine().Split().ToArray();
                int nodeStart = int.Parse(nodeStr[0]);
                int nodeEnd = int.Parse(nodeStr[1]);
                nodeArray[nodeStart].AddNode(nodeEnd);
                nodeArray[nodeEnd].AddNode(nodeStart);
            }
            foreach(Node item in nodeArray)
            {
                item.connectNodeNum.Sort(); //오름차순 정렬(정점 번호가 낮은거부터 해야하므로)
            }
            //4. DFS를 써보자 
            //한쪽방향으로 쭉 탐색해야한다. -> 2번부터하면서? Reverse해놔야할듯.
            Stack<int> nodeStack = new Stack<int>();
            bool[] isVisitedDFS = new bool[n+1];
            List<int> answerDFS = new List<int>();
            //초기 정보 넣기
            isVisitedDFS[v] = true;
            answerDFS.Add(v);
            int nodeCount = nodeArray[v].connectNodeNum.Count;
            for (int i = nodeCount - 1; i >= 0; i--)
            {
                //스택은 LIFO이므로 반대쪽으로 넣어준다
                nodeStack.Push(nodeArray[v].connectNodeNum[i]);
            }
            
            while(nodeStack.Count > 0)
            {
                int curNode = nodeStack.Pop();
                //방문한적이 없다면
                if (!isVisitedDFS[curNode])
                {
                    answerDFS.Add(curNode);
                    isVisitedDFS[curNode] = true;
                    //역순으로 다시 노드 추가를 해준다.
                    //foreach(int item in nodeArray[curNode].connectNodeNum)
                    int curNodeCount = nodeArray[curNode].connectNodeNum.Count;
                    for(int i=curNodeCount-1; i >= 0; i--)
                    {
                        int nodeNumber = nodeArray[curNode].connectNodeNum[i];
                        //방문한적이 없었다면
                        if (!isVisitedDFS[nodeNumber])
                        {
                            nodeStack.Push(nodeNumber);
                        }
                    }
                }
            }
            //출력
            for(int i=0; i< answerDFS.Count; i++)
            {
                Console.Write(answerDFS[i]);
                if (i < n - 1) Console.Write(" "); //공백 하나 추가
            }
            Console.WriteLine();
            
            //3. BFS로 찾아보자
            //FIFO해야함
            List<int> visitedNode = new List<int>();
            Queue<int> nodeQueue = new Queue<int>();
            
            visitedNode.Add(v); //자기자신은 무조건 처음에 추가
            
            foreach(int item in nodeArray[v].connectNodeNum)
            {
                nodeQueue.Enqueue(item);
            }
            while(nodeQueue.Count > 0)
            {
                int curNode = nodeQueue.Dequeue();
                if(!visitedNode.Contains(curNode))
                {
                    //추가
                    visitedNode.Add(curNode);
                    //해당 노드에 있는 간선으로 연결된 노드정보들 추가
                    foreach(int nodeIndex in nodeArray[curNode].connectNodeNum)
                    {
                        nodeQueue.Enqueue(nodeIndex);
                    }
                }
            }
            //BFS 출력
            for(int i= 0; i< visitedNode.Count; i++)
            {
                Console.Write(visitedNode[i]);
                if(i < visitedNode.Count-1)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}