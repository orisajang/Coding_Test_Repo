using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace baek7785
{
    class Program
    {
        static void Main(string[] args)
        {
			int n = int.Parse(Console.ReadLine());
			Dictionary<string,bool> enterRecord = new Dictionary<string,bool>();
			for(int i=0; i< n; i++)
			{
				string[] msg = Console.ReadLine().Split(' ').ToArray();
				bool isEnter = false;
				if(msg[1] == "enter") {isEnter = true; }
				else if(msg[1] == "leave") {isEnter = false; }
				enterRecord[msg[0]] = isEnter;
			}
			StringBuilder sb = new StringBuilder();
            List<string> nameList = new List<string>();
            foreach(string name in enterRecord.Keys)
            {
                if(enterRecord[name] == true)
                {
                    nameList.Add(name);
                }
            }
            nameList.Sort();
            nameList.Reverse();
            
			foreach(string name in nameList)
			{
				sb.AppendLine(name);
			}
			Console.WriteLine(sb.ToString());
        }
        
    }
}