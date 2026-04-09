using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace baek24444
{
    class Program
    {
        static void Main(string[] args)
        {
            //초기 입력처리 및 초기화
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int>[] listArray = new List<int>[inputArray[0] + 1];
            for(int i=0; i< listArray.Length; i++)
            {
                listArray[i] = new List<int>();
            }
            for(int i=0; i< inputArray[1]; i++)
            {
                int[] lineArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                listArray[lineArray[0]].Add(lineArray[1]);
                listArray[lineArray[1]].Add(lineArray[0]);
            }
            //오름차순 정렬 필요
            for(int i=0; i< listArray.Length; i++)
            {
                listArray[i].Sort();
            }
            //이제 bfs로 처리
            Queue<int> vertexQue = new Queue<int>();
            bool[] isVisited = new bool[inputArray[0] + 1];
            int[] result = new int[inputArray[0] + 1];
            int count = 1;
            vertexQue.Enqueue(inputArray[2]);
            isVisited[inputArray[2]] = true;
            while(vertexQue.Count > 0)
            {
                int num = vertexQue.Dequeue();
                result[num] = count++;
                //리스트에서 해당 번호와 연결된 곳을 찾아서 방문했으면 안하고, 방문안했으면 처리하기
                for(int i=0; i< listArray[num].Count; i++)
                {
                    int currentNum = listArray[num][i];
                    if (!isVisited[currentNum])
                    {
                        //방문한적이 없다면? 큐에 넣어주고 계속 진행한다
                        isVisited[currentNum] = true;
                        vertexQue.Enqueue(currentNum);
                    }
                }
            }
            StringBuilder sb = new StringBuilder();
            for(int i=1; i< result.Length; i++)
            {
                sb.AppendLine(result[i].ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}