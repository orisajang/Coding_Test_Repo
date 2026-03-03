using System;
using System.Collections.Generic;
using System.Text;
namespace baek24479
{
	class Program
    {
        static bool[] isVisited;
        static int[] answer;
        static int answerIndex = 1;
        public static void dfs(List<int>[] data , int startNum)
        {
            //자신 처리
            if(!isVisited[startNum])
            {
                isVisited[startNum] = true;
                answer[startNum] = answerIndex++;
            }
            //다음 노드 처리
            for(int i=0; i< data[startNum].Count; i++)
            {
                int num = data[startNum][i];
                if(!isVisited[num])
                {
                    isVisited[num] = true;
                    answer[num] = answerIndex;
                    answerIndex++;
                    dfs(data,num);
                }
            }
        }
    	public static void Main(string[] args)
        {
        	int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int>[] graphList = new List<int>[inputArray[0]+1];
            for(int i=0; i<= inputArray[0]; i++)
            {
                graphList[i] = new List<int>();
            }
            //입력을 받으면서 체크
            for(int i=0; i< inputArray[1]; i++)
            {
                int[] lineInfo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                //그래프에 간선정보를 추가해준다
                graphList[lineInfo[0]].Add(lineInfo[1]); 
                graphList[lineInfo[1]].Add(lineInfo[0]); 
            }
            //오름차순이므로 정렬 하기
            for(int i=1; i<= inputArray[0]; i++)
            {
                if(graphList[i].Count > 0)
                {
                    graphList[i].Sort();
                }
            }
            //이제 결과값을 출력. 시작점에서부터 방문한노드 체크하면서 진행
            isVisited = new bool[inputArray[0]+1];
            answer = new int[inputArray[0]+1];
            //dfs처리
            dfs(graphList,inputArray[2]);
            StringBuilder sb = new StringBuilder();
            for(int i=1; i < answer.Length; i++)
            {
                sb.AppendLine(answer[i].ToString());
            }
            Console.WriteLine(sb.ToString());
        }

        
    }
}