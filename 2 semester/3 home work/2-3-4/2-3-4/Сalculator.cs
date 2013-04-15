using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_4
{
    public class Calculator
    {
        public string Str { get; set; }

        public Calculator(string str)
        {
            this.Str = str;
        }

        /// <summary>
        /// Reads out a number from a string starting from a given position
        /// </summary>
        /// <param name="str">string with number</param>
        /// <param name="position">position after which number begins</param>
        /// <returns>number</returns>
        public int GetNumber(int position)
        {
            int number = 0;
            while (Str[position + 1] >= '0' && Str[position + 1] <= '9')
            {
                number = number * 10 + Str[++position] - '0';
                if (position + 1 >= Str.Length)
                {
                    break;
                }
            }
            return number;
        }

        /// <summary>
        /// Calculate an expression
        /// </summary>
        /// <returns>result of an expression</returns>
        public int Calculate()
        {
            IStack stack = new StackArray();
            int position = -1;
            stack.Push(GetNumber(position));
            position++;
            while (position < Str.Length)
            {
                switch (Str[position])
                {
                    case '*':
                        {
                            stack.Push(stack.Pop() * GetNumber(position));
                            break;
                        }
                    case '/':
                        {
                            stack.Push(stack.Pop() / GetNumber(position));
                            break;
                        }
                    case '+':
                        {
                            while (stack.AmountOfElements() > 1)
                            {
                                stack.Push(stack.Pop() + stack.Pop());
                            }
                            stack.Push(GetNumber(position));
                            break;
                        }
                    case '-':
                        {
                            while (stack.AmountOfElements() > 1)
                            {
                                stack.Push(stack.Pop() + stack.Pop());
                            }
                            stack.Push(-GetNumber(position));
                            break;
                        }
                }
                position++;
            }
            while (stack.AmountOfElements() > 1)
            {
                stack.Push(stack.Pop() + stack.Pop());
            }
            return stack.Pop();
        }
    }
}