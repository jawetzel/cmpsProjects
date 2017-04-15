using System;
using System.Runtime.Serialization;

namespace HomeWork3.Stack
{
    [Serializable]
    internal class EmptyStackException : Exception
    {
        public EmptyStackException()
        {
            Console.WriteLine("encountered null exception with Stack");
            Console.Read();
            Environment.Exit(0);
        }

        public EmptyStackException(string message) : base(message)
        {
        }

        public EmptyStackException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EmptyStackException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}