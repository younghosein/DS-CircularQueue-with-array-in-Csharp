using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            CicularQueue Q = new CicularQueue(5);

            Q.insert(10);
            Q.insert(20);
            Q.insert(30);
            Q.insert(40);
            Q.insert(50);

            Console.WriteLine("Items are : ");
            Q.printQueue();

            Q.delete();
            Q.delete();

            Q.insert(60);
            Q.insert(70);

            Console.WriteLine("Items are : ");
            Q.printQueue();

            Console.ReadKey();

        }
    }
}

