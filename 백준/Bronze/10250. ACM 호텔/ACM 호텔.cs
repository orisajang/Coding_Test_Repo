using System;

namespace baekjoon10250
{
    class Program
    {
         static void Main(string[] args)
         {
            int loop = int.Parse(Console.ReadLine());
            for(int i=0; i< loop; i++)
            {
                //입력 처리
                string[] strArray = Console.ReadLine().Trim().Split(' ');
                int[] nums = new int[strArray.Length];
                int index = 0;
                foreach(string str in strArray)
                {
                    nums[index] = int.Parse(str);
                    index++;
                }
                //데이터를 뽑아준다
                int hotelHeight = nums[0];
                int hotelWidth = nums[1];
                int customerIndex = nums[2];

                //한줄에6개, 총 12번까지 가능
                int selectWidght = customerIndex / hotelHeight; //1
                int selectHeight = customerIndex % hotelHeight; //4
                
                //맨위층인 경우 처리
                if(selectHeight == 0)
                {

                    selectWidght -= 1;
                    selectHeight = hotelHeight;
                }
                //출력
                string widthStr = "";
                widthStr = (selectWidght + 1).ToString("D2");
                string msg = selectHeight.ToString() + widthStr;
                Console.WriteLine(msg);

            }
         }
    }
}