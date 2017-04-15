using System;
using System.Collections.Generic;

namespace HomeWork3.HW3.Conversion
{
    public class InFix
    {
        Queue.Queue _queue = new Queue.Queue();
        Stack.Stack _stack = new Stack.Stack();
        public string Expression { get; set; }

        public InFix(string expression)
        {
            Expression = expression;
        }

        public PostFix ToPostFix()
        {
            List<char> operatorsList = new List<char>() {'+','-','*','/'};
            List<char> additiveOp = new List<char>() {'+','-'};
            List<char> multiplicativeOp = new List<char>() {'*','/'};

            string returnString = "";

            foreach (char input in Expression)   //7
            {
                if (input > 96 && input < 123)  //2
                {
                    _queue.EnQueue(input);
                    continue;
                }

                if (input == '(')               //3
                {
                    _stack.Push(input);
                    continue;
                }

                if (input == ')')               //4
                {
                    while ((char)_stack.Peek() != '(')
                    {
                        _queue.EnQueue(_stack.Pop());
                    }
                    _stack.Pop();
                    continue;
                }

                if (operatorsList.Contains(input) && (_stack.GetSize() == 0 || (char)_stack.Peek() == '(')) //5
                {
                    _stack.Push(input);
                    continue;
                }

                while (!_stack.IsEmpty() && (additiveOp.Contains(input) && multiplicativeOp.Contains((char)_stack.Peek())))  //6
                {
                    if (operatorsList.Contains(input) && !_stack.IsEmpty())
                    {
                        if (additiveOp.Contains(input) && multiplicativeOp.Contains((char)_stack.Peek()))
                        {
                            _queue.EnQueue(_stack.Pop());
                        }
                        else
                        {
                            _stack.Push(input);
                        }
                    }
                }
            }

            while (!_stack.IsEmpty())
            {
                _queue.EnQueue(_stack.Pop());
            }

            while (!_queue.IsEmpty())
            {
                returnString += _queue.DeQueue();
            }

            return new PostFix(returnString);
        }
    }
}
