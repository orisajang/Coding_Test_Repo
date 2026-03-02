using System;
using System.Collections.Generic;
using System.Text;
namespace baek1018
{
	class Program
    {
        static string[] White = new string[]
        {
            "BWBWBWBW",
            "WBWBWBWB",
            "BWBWBWBW",
            "WBWBWBWB",
            "BWBWBWBW",
            "WBWBWBWB",
            "BWBWBWBW",
            "WBWBWBWB"
        };
        static string[] Black = new string[]
        {
            "WBWBWBWB",
            "BWBWBWBW",
            "WBWBWBWB",
            "BWBWBWBW",
            "WBWBWBWB",
            "BWBWBWBW",
            "WBWBWBWB",
            "BWBWBWBW"
        };
        
    	public static void Main(string[] args)
        {
        	string[] inputArray = Console.ReadLine().Split(' ');
            int n = int.Parse(inputArray[0]);
            int m = int.Parse(inputArray[1]);
            char[,] chArray = new char[n,m];
            for(int i=0; i<n; i++ )
            {
                string str = Console.ReadLine();
                for(int j=0; j< str.Length; j++)
                {
                    chArray[i,j] = str[j];
                }
            }
            //이제 전체에서 2중for문 돌려서 체스판을 찾는다
            int answer = 0;
            
            for(int i=0; i<= n-8; i++)
            {
                for(int j=0; j<= m-8; j++)
                {
                    //이제 전체를 비교하는걸 찾자
                    //현재 비교해야하는 범위값은? i부터+7 j부터 +7범위까지
                    int countX = 0;
                    int countY = 0;
                    int answerCountW = 0;
                    int answerCountB = 0;
                    for(int x=i; x<i+8; x++)
                    {
                        for(int y=j; y<j+8; y++)
                        {
                            //1.White와 비교하자
                            if(White[countX][countY] != chArray[x,y]) { answerCountW++; }
                            //2.Black과 비교하자
                            if(Black[countX][countY] != chArray[x,y]) { answerCountB++; }
                            
                            countY++;
                        }
                        countX++;
                        countY = 0;
                    }
                    //전부 다 끝난이후 최소값인지 확인
                    int answerMin = (answerCountW < answerCountB) ? answerCountW : answerCountB;
                    //초기값 넣어주기
                    if(i==0 && j==0) { answer = answerMin; }
                    answer = (answer < answerMin) ? answer : answerMin;
                }

            }
            Console.WriteLine(answer);
        }
    }
}