using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace translate_javacode
{
    
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

        public T Push(T element)
        {
            if (element == null)
            {
                throw new NullReferenceException();
            }

            if (IsEmpty())
            {
                Node<T> tmp = new Node<T>(element, null);
                rear = front = tmp;
            }
            else
            {
                Node<T> tmp = new Node<T>(element, null);
                rear.next = tmp;
                rear = tmp;
            }

            return element;
        }

        public T Pop()
        {
            T tmp = default(T);
            if (IsEmpty())
            {
                throw new QueueUnderflowException("This queue was empty when pop was invoked.");
            }
            else if (front == rear)
            {
                tmp = front.data;
                front = null;
                rear = null;
            }
            else
            {
                tmp = front.data;
                front = front.next;
            }

            return tmp;

        }

        public bool IsEmpty()
        {
            if (front == null && rear == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    //Don't have to import anything because of the same namespace
    class MainClass
    {
        static LinkedList<string> generateBinaryRepresentationList(int n)
        {
            LinkedQueue<StringBuilder> q = new LinkedQueue<StringBuilder>();

            LinkedList<string> output = new LinkedList<string>();

            if(n < 1)
            {

                return output;
            }


            q.Push(new StringBuilder("1"));

            //BFS
            while (n-- > 0)
            {
                StringBuilder sb = q.Pop();
                output.AddLast(sb.ToString());

                StringBuilder sbc = new StringBuilder(sb.ToString());

                sb.Append('0');
                q.Push(sb);

                sbc.Append('1');
                q.Push(sbc);

            }
            return output;

        }

        static void Main(string[] args)
        {


            int n = 10;
            if (args.Length < 1)
            {
                Console.WriteLine("Please invoke with the max value to print binary up to, like this:");
                Console.WriteLine("\tjava Main 12");
                return;
            }
            try
            {
                n = int.Parse(args[0]);
            }
            catch (FormatException)
            {
                Console.WriteLine("I'm sorry, I can't understand the number: " + args[0]);
                return;
            }

            LinkedList<string> output = generateBinaryRepresentationList(n);


            int maxLength = output.Last().Length;

            foreach (string s in output)
            {
                for(int i =0; i < maxLength - s.Length; ++i)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(s);
            }        
        }
    }
}
