using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            IStack stack = new Stack();
            string str = null;
            Console.Write("Write an expression: ");
            str = Console.ReadLine();
            Calculator calculator = new Calculator(str, stack);
            Console.WriteLine("{0}", calculator.Calculate());
         }
    }
}
