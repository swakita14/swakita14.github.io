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

    interface IQueueInterface<T>
    {
        T push(T element);

        T pop();

        bool isEmpty();

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
}
