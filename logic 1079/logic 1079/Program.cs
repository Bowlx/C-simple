using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic_1079
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> tests = new List<int>();
            int x;
            while ((x = Convert.ToInt32(Console.ReadLine())) != 0) tests.Add(x);            
            List<int> smth = new List<int>();
            for (int i = 0; i < tests.Count; i++)
            {        
                smth.Add(0);
                smth.Add(1);
                for (int j = 2; j <= tests[i]; j++)
                {
                    if (j % 2 == 0) smth.Add(smth[j / 2]);
                    else  smth.Add(smth[(j - 1) / 2 + 1] + smth[(j - 1) / 2]);                  
                }
                Console.WriteLine(smth.Max());
            }
            Console.ReadKey();
        }
    }
}