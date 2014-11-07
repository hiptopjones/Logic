using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            FullAdder adder = new FullAdder();
            InstanceCounter.DumpCounts();

            WaitForKey();
        }

        static void WaitForKey()
        {
            Console.WriteLine("Hit a key to continue...");
            Console.ReadKey();
        }
    }
}
