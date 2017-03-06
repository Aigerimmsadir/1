using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
      public static bool isDevisible( string a)
        {
            int k = int.Parse(a);
            if(k%1000==0 && k%15!=0)
            return true;
            return false;

        }
        static List<string> list = new List<string>();
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (isDevisible(args[i]))
                    Console.WriteLine(args[i]);
            }
        }
    }
}
