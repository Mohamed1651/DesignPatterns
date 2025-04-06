using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Interpreter
{
    public class ExpressionParser
    {
        public static IExpression Parse(string input)
        {
            var tokens = input.Split(' ');
            Stack<IExpression> stack = new Stack<IExpression>();

            for(int i = 0; i < tokens.Length; i++)
            {
                string token = tokens[i];

                if(int.TryParse(token, out int number))
                {
                    stack.Push(new NumberExpression(number));
                }
                else if(token == "+" || token == "-")
                {
                    IExpression left = stack.Pop();
                    i++;
                    IExpression right = new NumberExpression(int.Parse(tokens[i]));

                    if (token == "+")
                    {
                        stack.Push(new AddExpression(left, right));
                    }
                    else
                    {
                        stack.Push(new SubtractExpression(left, right));
                    }
                }
            }
            return stack.Pop();
        }
    }
}
