using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace DictionaryEx
{
    class StackAsQueue
    {
        public class Queue
        {
            public Stack s1 = new Stack();
            public Stack s2 = new Stack();

            public void enQueue(int x)
            { 
                while (s1.Count > 0)
                {
                    s2.Push(s1.Pop());
                    //s1.Pop();
                }
                s1.Push(x);
                while (s2.Count > 0)
                {
                    s1.Push(s2.Pop());
                    //s2.Pop();
                }
            }
            public int deQueue()
            {
                if (s1.Count == 0)
                {
                    Console.WriteLine("Q is Empty");

                }
                int x = (int)s1.Peek();
                s1.Pop();
                return x;
            }
        };
        public static void Main7()
        {
            Queue q = new Queue();
            q.enQueue(1);
            q.enQueue(2);
            q.enQueue(3);

            Console.Write(q.deQueue() + " ");
            Console.Write(q.deQueue() + " ");
            Console.Write(q.deQueue());
        }
    }
}
