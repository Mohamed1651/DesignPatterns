using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Interpreter
{
    public class AddExpression : IExpression
    {
        private IExpression _leftExpression;
        private IExpression _rightExpression;

        public AddExpression(IExpression leftExpression, IExpression rightExpression)
        {
            _leftExpression = leftExpression;
            _rightExpression = rightExpression;
        }

        public int Interpret()
        {
            return _leftExpression.Interpret() + _rightExpression.Interpret();
        }
    }
}
