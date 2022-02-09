using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryEx
{
    class QueueArray
    {
        public static void Main5(string[] args)
        {
            int s = 2;
            Queue q = new Queue(s);

            int a = 128,
                b = 256;

            q.Enqueue(a);
            q.Enqueue(b);

            a = q.Dequeue();
            b = q.Dequeue();

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }

    public class Queue
    {
        private int[] queue;
        private int p;

        public Queue(int s)
        {
            p = -1;
            queue = new int[s];
        }

        public void Enqueue(int x)
        {
            p++;
            queue[p] = x;
        }

        public int Dequeue()
        {
            int aux = queue[0];

            for (int i = 0; i < p; i++)
            {
                queue[i] = queue[i + 1];
            }

            queue[p] = aux;
            p--;

            return queue[p + 1];
        }
    }
}
