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
            Console.WriteLine("Enter email: ");
            string str=Console.ReadLine();

            bool flag = pattern.Validate(str);
            Console.WriteLine(flag);
            Console.ReadLine();
        }
    }
}
