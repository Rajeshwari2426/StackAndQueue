using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    internal class LinkedListQueue
    {
        private Node front;
        
         
        public void Enqueue(int value)
        {
            Node node = new Node(value);
            if (this.front == null)
                this.front = node;
            else
            {
                Node rear = front;
                while (rear.next != null)
                {
                    rear = rear.next;
                }
                rear.next = node;
            }
            Console.WriteLine("{0} Enqueued into Queue", value);
        }
        
        /// display the elements of Queue.
        
        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Node temp = front;
                while (temp != null)
                {
                    Console.WriteLine("Element in Queue:" + temp.data);
                    temp = temp.next;
                }
            }
        }
        //remove elements from queue
        public void Dequeue()
        {
            if (this.front == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            Node temp = this.front;
            this.front = front.next;
            temp.next = null;
            Console.WriteLine("{0} Dequeued from Queue", temp.data);
        }
        
       
    }
}
