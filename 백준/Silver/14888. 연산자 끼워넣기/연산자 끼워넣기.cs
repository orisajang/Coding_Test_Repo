using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp
{
	class Program
    {
        public enum operType
        {
            plus, minus,multy,div
        }
        
        static int[] numArray;
        static int[] operArray;
        static operType[] selectedOper;
        static int max = int.MinValue;
        static int min = int.MaxValue;
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            numArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            operArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            selectedOper = new operType[numArray.Length-1];
        
            Func(0);
            Console.WriteLine(max);
            Console.WriteLine(min); 
        }
        
        static void Func(int depth)
        {
            if(depth >= numArray.Length-1)
            {
                //이제 여기서 계산을 해주면된다
                int sum = numArray[0];
                for(int i=0; i< selectedOper.Length; i++)
                {
                    switch(selectedOper[i])
                    {
                        case operType.plus:
                            sum += numArray[i + 1];
                            break;
                        case operType.minus:
                            sum -= numArray[i + 1];
                            break;
                        case operType.multy:
                            sum *= numArray[i + 1];
                            break;
                        case operType.div:
                            if(sum < 0)
                            {
                                sum = (-sum) / numArray[i + 1];
                                sum *= -1;
                            }
                            else
                            {
                                sum /= numArray[i + 1];
                            }
                            break;
                    }
                }
                if(max < sum)
                {
                    max = sum;
                }
                if(min > sum)
                {
                    min = sum;
                }
        
        
                return;
            }
            //아직 안되었다면 선택을 해주자
            for(int i=0; i< operArray.Length; i++)
            {
                int count = 0;
                while (operArray[i] > 0)
                {
                    //1개 더해줌
                    count++;
                    operArray[i]--;
                    //재귀
                    selectedOper[depth] = (operType)i;
                    Func(depth+1);
                }
                //계산 끝났으니까 다시 반환해준다.
                operArray[i] += count;
            }
            
        }
    }
}