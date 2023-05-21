using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class CicularQueue
    {
        private int[] ele;
        private int front;
        private int rear;
        private int max;
        private int count;

        public CicularQueue(int size)
        {
            ele = new int[size];
            front = 0;
            rear = -1;
            max = size;
            count = 0;
        }

        public void insert(int item)
        {
            if (count == max)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                rear = (rear + 1) % max;
                ele[rear] = item;

                count++;
            }
        }

        public void delete()
        {
            if (count == 0)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine("deleted element is: " + ele[front]);

                front = (front + 1) % max;

                count--;
            }
        }

        public void printQueue()
        {
            int i = 0;
            int j = 0;

            if (count == 0)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                for (i = front; j < count;)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + ele[i]);

                    i = (i + 1) % max;
                    j++;

                }
            }
        }
        public void AvgMinQueue()
        {
            int i = 0;
            int j = 0;
            int s = 0;
            if (count == 0)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                if (ele[i] < 0)
                {
                    for (i = front; j < count;)
                    {
                        Console.WriteLine((s += ele[i]) / count);

                        i = (i + 1) % max;
                        j++;

                    }
                }
            }
        }
    }

}
