using System;
using System.Collections.Generic;
using System.Text;
namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            //현재 문자열에서 숫자를 분리한다.
            Queue<int> numQueue = new Queue<int>();
            Queue<char> operQueue = new Queue<char>();
            StringBuilder sb = new StringBuilder();
            for(int i=0; i < str.Length; i++)
            {
                if('0' <= str[i] &&
                    str[i] <= '9')
                {
                    //숫자임
                    sb.Append(str[i]);
                }
                else
                {
                    //+나 -문자이다.
                    operQueue.Enqueue(str[i]);
                    numQueue.Enqueue(int.Parse(sb.ToString()));
                    sb.Clear();
                }
            }
            if(sb.Length != 0)
            {
                //마지막 숫자도 변환해준다
                numQueue.Enqueue(int.Parse(sb.ToString()));
                sb.Clear();
            }
            //숫자 정보들과 연산자 정보들을 저장했으니까, 이거를 가지고 최소값을 찾는다
            //첫번째 숫자는 무조건 더함(0이상이므로)
            int sum = numQueue.Dequeue();
            int minusSum = 0;
            bool isMinus = false;
            while(numQueue.Count > 0)
            {
                if(isMinus)
                {
                    minusSum += numQueue.Dequeue();
                    continue;
                }
                if(operQueue.Count <= 0)
                {
                    continue;
                }
                char operType = operQueue.Dequeue();

                if (operType == '-')
                {
                    //한번이라도 마이너스가 나오면 그 이후의 값은 전부 마이너스임
                    isMinus = true;
                }
                else
                {
                    sum += numQueue.Dequeue();
                }
            }
            sum -= minusSum;
            Console.WriteLine(sum);
        }
    }
}

