using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            //아이디어: 앞쪽부터 계속 더한다.만약 더한 수가 지금 현재값보다 작다면? 지금값으로 최대값 갱신
            int t = int.Parse(Console.ReadLine());
            //5층의 6호에 살려면 4층의 1호부터 5호까지 사람들의 수의 합만큼 
            //0층의 3호까지 사람의 합을 구해야함, 1,2,3
            for(int i=0; i< t; i++)
            {
                int k = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());
                int[,] data = new int[k + 1, n];
                //0번부터 채워주자.
                for(int j=0; j<n; j++)
                {
                    data[0, j] = j + 1;
                }
                //이제 1번부터 쭉 들어가면서 값을 채워준다
                //1 2 3
                //1 3 6
                //1 4 10 -> 0이면[0]만, 아니라면, [0] + 현재
                for(int row =1; row <= k; row++)
                {
                    for(int col = 0; col < n; col++)
                    {
                        if(col == 0)
                        {
                            data[row, col] = data[row - 1, col];
                        }
                        else
                        {
                            data[row, col] = data[row, col - 1] + data[row - 1, col];
                        }
                    }
                }
                Console.WriteLine(data[k,n-1]);
            }

        }
    }
}