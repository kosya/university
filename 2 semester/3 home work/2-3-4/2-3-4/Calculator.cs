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
        private IStack stack;

        public Calculator(string str, IStack stack)
        {
            this.Str = str;
            this.stack = stack;
        }

        /// <summary>
        /// Method, which adds one number to another
        /// </summary>
        public void Addition()  
        {
            stack.Push(stack.Pop() + stack.Pop());
        }

        /// <summary>
        /// Method, which divide one number by another
        /// </summary>
        public void Division()
        {
            float tmp = stack.Pop();
            if (tmp == 0)
            {
                throw new DivideZeroException("Division by zero");
            }
            stack.Push(stack.Pop() / tmp);
        }

        /// <summary>
        /// Method, which subtract one nomber from another
        /// </summary>
        public void Subtraction()
        {
            stack.Push(-stack.Pop() + stack.Pop());
        }

        /// <summary>
        /// Method, which multiply two numbers
        /// </summary>
        public void Multiplication()
        {
            stack.Push(stack.Pop() * stack.Pop());
        }

        /// <summary>
        /// Calculate an expression
        /// </summary>
        /// <returns>result of an expression</returns>
        public float Calculate()
        {
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
                            Multiplication();
                            position++;
                            break;
                        }
                    case '/': 
                        {
                            counter += 2; // passing useless elements in the split array ("")
                            Division();
                            position++;
                            break;
                        }
                    case '+':
                        {
                            counter += 2; // passing useless elements in the split array ("")
                            Add();
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
                                    Subtraction();
                                    position++;
                                }
                            }
                            else
                            {
                                counter += 2; // passing useless elements in the split array ("")
                                Subtraction();
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
