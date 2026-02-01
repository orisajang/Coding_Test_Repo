using System;
using System.Collections.Generic;
using System.Linq;

namespace back1966
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            //n번 반복할거임
            for(int i=0; i< testCase; i++)
            {
                int answer = 1;
                //첫번째 입력. 문서갯수, 몇번째것 찾는지
                string[] array1 = Console.ReadLine().Split(" ");
                //문서의 갯수와 몇번째것을 찾아야하는지
                int documentCount = int.Parse(array1[0]);
                int documentIndex = int.Parse(array1[1]);
                Queue<(int,int)> que = new Queue<(int,int)>();
                //두번째 입력. 우선도 배열
                string[] array2 = Console.ReadLine().Split(" ");
                //큐에 현재인덱스와 현재 인덱스의 우선순위 정보를 넣음
                int index= 0;
                List<int> priorityList = new List<int>();
                foreach(string priority in array2)
                {
                    //큐 정보와 최대값 측정을 위한 우선순위 리스트 설정
                    int number = int.Parse(priority);
                    que.Enqueue((index,number));
                    priorityList.Add(number);
                    index++;
                }
                //Max값부터 빠져나가야 하므로 Max값을 찾는다.
                priorityList.Sort();
                priorityList.Reverse();
                
                while(que.Count > 0)
                {
                    (int,int) tupleData = que.Dequeue();
                    //현재 값이 최대값이라면
                    if(priorityList[0]== tupleData.Item2)
                    {
                        //찾고있는 사람 인덱스와 같다면? 
                        if(tupleData.Item1 == documentIndex)
                        {
                            //몇번째에 찾았는지 출력
                            Console.WriteLine(answer);
                            break;
                        }
                        else {answer++; }
                        priorityList.RemoveAt(0);
                    }
                    else 
                    {
                        //현재가 최대값이 아니라면 다시 큐에 넣어줌
                        que.Enqueue(tupleData);
                    }
                }

                
                
            }
        }
    }
}