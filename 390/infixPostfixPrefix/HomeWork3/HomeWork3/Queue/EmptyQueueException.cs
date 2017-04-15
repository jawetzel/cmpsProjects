using System;
using System.Net.Mime;
using System.Runtime.Serialization;

namespace HomeWork3.Queue
{
    [Serializable]
    internal class EmptyQueueException : Exception
    {
        public EmptyQueueException()
        {
            Console.WriteLine("encountered null exception with Queue");
            Console.Read();
            Environment.Exit(0);
        }

        public EmptyQueueException(string message) : base(message)
        {
        }

        public EmptyQueueException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EmptyQueueException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}