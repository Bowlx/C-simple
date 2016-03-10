using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic1409
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] smth = Console.ReadLine().Split(' ');
            Console.WriteLine((Convert.ToInt32(smth[1]) - 1) + " " + (Convert.ToInt32(smth[0]) - 1));
        }
    }
}
