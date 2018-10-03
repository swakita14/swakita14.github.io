using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace translate_javacode
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Node<T>
    {
        public T data;
        public Node<T> next;


        public Node(T data, Node<T> next)
        {
            this.data = data;
            this.next = next;
        }

    }

    public interface IQueueInterface<T>
    {
        T Push(T element);

        T Pop();

        bool IsEmpty();

    }

    class QueueUnderflowException : SystemException
    {
        public QueueUnderflowException() : base()
        {
            
        }

        public QueueUnderflowException(string msg) : base(msg)
        {

        }

    } 

    class LinkedQueue<T> : IQueueInterface<T>
    {
        private Node<T> front;
        private Node<T> rear;

        public LinkedQueue()
        {
            front = null;
            rear = null;
        }




    }
}
