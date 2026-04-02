using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace baek1992
{
    class Program
    {
        static char[][] dataArray;
        static StringBuilder sb = new StringBuilder();
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            dataArray = new char[n][];
            for(int i=0; i< n; i++)
            {
                dataArray[i] = new char[n];
                string str = Console.ReadLine();
                for(int j=0; j< str.Length; j++)
                {
                    dataArray[i][j] = str[j];
                }
            }
            //계산 시작
            Func(0, 0, n);
            Console.WriteLine(sb.ToString());
        }
        static void Func(int row, int col, int length)
        {
            if (length <= 0) return;

            char startChar = dataArray[row][col];
            bool isSame = true;
            for(int x = row; x< row+length; x++)
            {
                for(int y= col; y< col+length; y++)
                {
                    if(startChar!= dataArray[x][y])
                    {
                        isSame = false;
                        break;
                    }
                }
                if (!isSame) { break; }
            }

            if(isSame)
            {
                //끝내고 빠져나감
                sb.Append(startChar);
            }
            else
            {
                //4방향으로 나누면서 다시 계산
                int half = length / 2;
                sb.Append('(');
                Func(row, col, half);
                Func(row, col+ half, half);
                Func(row + half, col, half);
                Func(row + half, col + half, half);
                sb.Append(')');
            }
        }
    }
}

