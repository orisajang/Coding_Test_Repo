using System;

class Program
{
    public static int count = 1;
    static int recursion(char[] msg,int left, int right)
    {
        count++;

        if (left >= right) return 1;
        else if (msg[left] != msg[right]) return 0;
        else
        {
            return recursion(msg, left + 1, right - 1);
        }
            
    }
    static int isPalindrome(char[] msg,int left, int right)
    {
        count = 0;
        return recursion(msg, left, right);
    }
    static void Main()
    {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                string str = Console.ReadLine();
                char[] ch = str.ToCharArray();
                int numTrue = isPalindrome(ch, 0, ch.Length - 1);

                Console.WriteLine($"{numTrue} {count}");
            }
    }
}