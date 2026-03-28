using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp
{
	class Program
    {
    	public static void Main(string[] args)
        {
            //배열에서 전부다 더해놓은다음에 인덱스에서 뒤 - 앞 으로 처리하면 될듯?
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] sumArray = new int[inputArray.Length];

            sumArray[0] = inputArray[0];
            //더한값을 미리 계산
            for(int i=1; i< sumArray.Length; i++)
            {
                sumArray[i] = sumArray[i - 1] + inputArray[i];
            }
            int max = int.MinValue;
            for(int i=0; i<= (sumArray.Length - input[1]); i++)
            {
                //5까지만 해야함. 
                int lastIndex = (i + input[1] - 1);
                //sumArray[i]값을 0으로 잡고 해야함
                int subValue = 0;
                if (i==0)
                {
                    //1이 됨
                    subValue = sumArray[lastIndex];
                }
                else
                {
                    subValue = (sumArray[lastIndex] - sumArray[i - 1]);
                }
                if (subValue > max) { max = subValue; }
            }

            Console.WriteLine(max);
        }
    }
}