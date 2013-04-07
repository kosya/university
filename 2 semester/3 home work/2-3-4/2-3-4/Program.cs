using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_4
{
    class Program
    {
        /// <summary>
        /// Reads out a number from a string starting from a given position
        /// </summary>
        /// <param name="str">string with number</param>
        /// <param name="position">position where number begins</param>
        /// <returns>number</returns>
        static public int GetNumber(string str, int position)
        {
            int number = 0;
            while (str[position + 1] >= '0' && str[position + 1] <= '9')
            {
                number = number * 10 + str[++position] - '0';
                if (position + 1 >= str.Length)
                {
                    break;
                }
            }
            return number;
        }

        static void Main(string[] args)
        {
            string str = null;
            Console.Write("Write an expression: ");
            str = Console.ReadLine();

            IStack stack = new StackArray();
            int position = -1;
            stack.Push(GetNumber(str, position));
            position++;
            while (position < str.Length)
            {
                switch (str[position])
                {
                    case '*':
                        {
                            stack.Push(stack.Pop() * GetNumber(str, position));
                            break;
                        }
                    case '/':
                        {
                            stack.Push(stack.Pop() / GetNumber(str, position));
                            break;
                        }
                    case '+':
                        {
                            while (stack.AmountOfElements() > 1)
                            {
                                stack.Push(stack.Pop() + stack.Pop());
                            }
                            stack.Push(GetNumber(str, position));
                            break;
                        }
                    case '-':
                        {
                            while (stack.AmountOfElements() > 1)
                            {
                                stack.Push(stack.Pop() + stack.Pop());
                            }
                            stack.Push(-GetNumber(str, position));
                            break;
                        }
                }
                position++;
            }
            while (stack.AmountOfElements() > 1)
            {
                stack.Push(stack.Pop() + stack.Pop());
            }
            Console.WriteLine("Result is: {0}", stack.Pop());
        }
    }
}
