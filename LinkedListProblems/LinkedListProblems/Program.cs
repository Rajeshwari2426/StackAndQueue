using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to Stack And Queue problem");
          LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(56);
            linkedListStack.Push(30);
            linkedListStack.Push(70);
            linkedListStack.Display();
            linkedListStack.Peek();
            linkedListStack.Display();
            
            linkedListStack.Pop();
            linkedListStack.Display();
            
            linkedListStack.IsEmpty();
            linkedListStack.Display();
            Console.WriteLine("<---Creating A Queue---> \n");
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Display();
            Console.WriteLine("<---Dequeue from Queue---> \n");
            linkedListQueue.Dequeue();
            linkedListQueue.Display();
           
            Console.ReadLine();
        }

    }
}
