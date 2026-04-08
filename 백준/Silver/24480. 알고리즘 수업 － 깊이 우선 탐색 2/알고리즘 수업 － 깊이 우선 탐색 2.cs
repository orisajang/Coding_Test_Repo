using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace baek24480
{
    class Program
    {
        static int[] result;
        static List<int>[] lineList;
        static int count = 1;
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //정점과 간선 정보를 넣자
            lineList = new List<int>[inputArray[0] + 1];
            for(int i=1; i< lineList.Length; i++)
            {
                lineList[i] = new List<int>();
            }
            for(int i=0; i< inputArray[1]; i++)
            {
                int[] dataArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                lineList[dataArray[0]].Add(dataArray[1]);
                lineList[dataArray[1]].Add(dataArray[0]);
            }
            //이제 정렬
            for(int i=1; i< lineList.Length; i++)
            {
                lineList[i].Sort((a, b) => b.CompareTo(a));
            }
            //판별 하기
            bool[] isVisited = new bool[inputArray[0] +1];
            result = new int[inputArray[0] + 1];
            Func(inputArray[2], result, isVisited);
            StringBuilder sb = new StringBuilder();
            for(int i=1; i< result.Length; i++)
            {
                sb.AppendLine(result[i].ToString());   
            }
            Console.WriteLine(sb.ToString());
        }
        private static void Func(int num , int[] index ,bool[] visited)
        {
            visited[num] = true;
            index[num] = count++;
            List<int> listBuf = lineList[num];
            for(int i=0; i< listBuf.Count; i++)
            {
                int next = listBuf[i];
                if (visited[next]) continue;
                Func(next, index, visited);
            }
        }

    }
}

