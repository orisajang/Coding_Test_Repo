using System;
using System.Collections.Generic;
using System.Text;

namespace back11725
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int>[] graph = new List<int>[n + 1];

            for(int i=0; i< graph.Count(); i++)
            {
                graph[i] = new List<int>();
            }

            for(int i=0; i< n-1; i++)
            {
                int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

                //BFS방식으로 다시 풀어보자 
                //먼저 그래프 형식으로 모든 정점 정보들을 저장해야 한다고 한다
                foreach(int index in inputArray)
                {
                    foreach(int other in inputArray)
                    {
                        if(other != index)
                        {
                            graph[index].Add(other);
                        }
                    }
                }
            }
            //그래프를 다 만들었으면 이제 1부터 시작이니까 1부터 빼주자
            Queue<int> nodeQue = new Queue<int>();
            bool[] isVisited = new bool[n + 1];
            int[] parentIndex = new int[n + 1];
            nodeQue.Enqueue(1);
            isVisited[1] = true;

            while (nodeQue.Count > 0)
            {
                //숫자를 빼주면서 트리를 만들어준다
                int num = nodeQue.Dequeue(); // 1이 나옴

                foreach(int item in graph[num])
                {
                    if (!isVisited[item])
                    {
                        isVisited[item] = true;
                        parentIndex[item] = num;
                        nodeQue.Enqueue(item);
                    }
                }
            }
            StringBuilder sb = new StringBuilder();
            for(int i=2; i<parentIndex.Length; i++)
            {
                sb.AppendLine(parentIndex[i].ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}