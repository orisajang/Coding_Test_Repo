using System;
using System.Collections.Generic;
using System.Linq;

namespace back7795
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            //테스트케이스 갯수만큼 for문 진행
            for(int i=0; i<T; i++ )
            {
                //첫째줄 입력으로 n과 m의 갯수를 받는다
                int[] numArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int n = numArray[0];
                int m = numArray[1];
                List<int> numListN = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                List<int> numListM = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                
                //1. m을 리스트로 만든다음 정렬. 다음숫자가 크다면 바로 종료
                numListM.Sort();
                int answer = 0;
                foreach(int hunterNumber in numListN)
                {
                    foreach(int foodNumber in numListM)
                    {
                        if(hunterNumber > foodNumber) { answer++; }
                        else { break; }
                    }
                }
                Console.WriteLine(answer);
                //(시간초과라면?)2. m을 리스트로 만든다음 정렬. 그다음에 탐색 알고리즘으로 찾으면 어떨까
            }
        }
    }
}