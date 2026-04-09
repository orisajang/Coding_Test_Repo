using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace baek9461
{
    class Program
    {
        static void Main(string[] args)
        {
            //1,1,1,2,2,3,4,5,7,9
            //3번째가 0번과 1번을 더한 숫자임
            //0~2번째는 수동으로 채워준다
            List<long> numList = new List<long>();
            numList.Add(1);
            numList.Add(1);
            numList.Add(1);

            int n = int.Parse(Console.ReadLine());
            for (int i=0; i< n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if(numList.Count < input)
                {
                    //채워주자 시작 번호는? 
                    //현재 4개, 10까지 구해야한다면? 6번 해야함
                    int startIndex = numList.Count;
                    for(int j=startIndex; j< input; j++)
                    {
                        long current = numList[j - 3] + numList[j - 2];
                        numList.Add(current);
                    }
                }
                //계산 다 끝났다면 바로 출력
                Console.WriteLine(numList[input - 1]);
            }
        }
    }
}