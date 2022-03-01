using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            bool flag = pattern.Validate("asd7x");
            Console.WriteLine(flag);
            Console.ReadLine();
        }
    }
}
