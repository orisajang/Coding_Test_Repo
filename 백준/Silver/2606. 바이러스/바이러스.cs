using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Test2
{
    class Program
    {
        static int result = 0;
        static List<int>[] nodeList;
        static void Main(string[] args)
        {
            int nodeCount = int.Parse(Console.ReadLine());
            int caseCount = int.Parse(Console.ReadLine());
            //리스트 초기화
            nodeList = new List<int>[nodeCount +1];
            for(int i=0; i< nodeList.Length; i++)
            {
                nodeList[i] = new List<int>();
            }
            //입력처리
            for (int i=0; i< caseCount; i++)
            {
                //양방향 노드 방식으로 추가
                int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                nodeList[inputArray[0]].Add(inputArray[1]);
                nodeList[inputArray[1]].Add(inputArray[0]);
            }
            //1번 컴퓨터가 웜 바이러스 걸렸을때 걸리게되는 컴퓨터 수를 출력하기
            bool[] isVisited = new bool[nodeCount + 1];
            Func(1, isVisited);

            Console.WriteLine(result);

        }
        static void Func(int num, bool[] isVisited)
        {
            if (isVisited[num]) return;

            isVisited[num] = true;
            if(num != 1)
            {
                result++;
            }
            List<int> listBuf = nodeList[num];
            for (int i = 0; i < listBuf.Count; i++)
            {
                Func(listBuf[i], isVisited);
            }
        }
    }
}