using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace HomeWork3.HW3.Conversion
{
    public class PostFix
    {
        Queue.Queue _queue = new Queue.Queue();
        Stack.Stack _stack = new Stack.Stack();
        public string Expression { get; set; }

        public PostFix(string expression)
        {
            Expression = expression;
        }
        public double Evaluate(List<string> operandsList)
        {
            
            foreach (char exp in Expression)
            {
                _queue.EnQueue(exp);
            }
            while (!_queue.IsEmpty())
            {
                var deQueued = (char)_queue.DeQueue();
                if (deQueued > 96 && deQueued < 123)
                {
                    var valueString = operandsList.FirstOrDefault(x => x.Contains(deQueued.ToString()));
                    _stack.Push(double.Parse(valueString.Split(' ')[1]));
                }
                else
                {
                    var valueA = (double)_stack.Pop();
                    var valueB = (double)_stack.Pop();
                    switch (deQueued)
                    {
                        case '+':
                            _stack.Push(valueA + valueB);
                            break;
                        case '-':
                            _stack.Push(valueA - valueB);
                            break;
                        case '/':
                            _stack.Push(valueA / valueB);
                            break;
                        case '*':
                            _stack.Push(valueA * valueB);
                            break;
                    }
                }
            }

            return (double)_stack.Pop();
        } 
    }
}