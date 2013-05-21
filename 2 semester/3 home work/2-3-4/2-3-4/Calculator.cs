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
        /// Calculate an expression
        /// </summary>
        /// <returns>result of an expression</returns>
        public float Calculate()
        {
            IStack stack = new StackArray();
            int position = 0; // position in the string
            string[] split = this.Str.Split(new char[] {' ', '+', '-', '/', '*'});
            int counter = 0;     // a number of an element from the split array 
            while (position < this.Str.Length)
            {
                switch (this.Str[position])
                {
                    case ' ':
                        {
                            position++;
                            break;
                        }
                    case '*':
                        {
                            counter += 2;  // passing useless elements in the split array ("")
                            stack.Push(stack.Pop() * stack.Pop());
                            position++;
                            break;
                        }
                    case '/': 
                        {
                            counter += 2; // passing useless elements in the split array ("")
                            float tmp = stack.Pop();
                            if (tmp == 0)
                            {
                                throw new DivideZeroException("Division by zero");
                            }
                            stack.Push(stack.Pop() / tmp);
                            position++;
                            break;
                        }
                    case '+':
                        {
                            counter += 2; // passing useless elements in the split array ("")
                            stack.Push(stack.Pop() + stack.Pop());
                            position++;
                            break;
                        }
                    case '-':
                        {
                            // Condition, which checks accessory of '-' to number
                            if (position + 1 < Str.Length)
                            {
                                if (Str[position + 1] != ' ')
                                {
                                    stack.Push(-float.Parse(split[++counter]));
                                    position += 1 + split[counter].Length; 
                                    counter++; // passing useless element in the split array ("")
                                }
                                else
                                {
                                    counter += 2; // passing useless elements in the split array ("")
                                    stack.Push(-stack.Pop() + stack.Pop());
                                    position++;
                                }
                            }
                            else
                            {
                                counter += 2; // passing useless elements in the split array ("")
                                stack.Push(-stack.Pop() + stack.Pop());
                                position++;
                            }
                            break;
                        }
                        // There are numbers in other cases 
                    default:
                        {
                            stack.Push(float.Parse(split[counter]));
                            position += split[counter].Length;
                            counter++;
                            break;
                        }
                }
            }
            return stack.Pop();
        }
    }
}
