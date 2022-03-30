using System;
using System.Collections.Generic;
using System.Text;

namespace Guess_Data_Structure_LL
{
    class QueueLL<QL>
    {
        Node<QL> front, rear, MyNode;
        public int count = 0;
        public QueueLL()
        {
            front = rear = null;
        }
        public bool isEmpty
        {
            get
            {
                return count == 0;
            }
        }
        public void EnQueueLL(QL data)
        {
            MyNode = new Node<QL>(data);
            if (rear == null)
            {
                rear = front = MyNode;
            }
            else
            {
                rear.Next = MyNode;
                rear = MyNode;
            }
        }
        public void DequeueLL()
        {
            if (rear == null)
                Console.WriteLine("QueueLL Is Empty");
            else
            Console.WriteLine("The DnQueueLL Ele = " + front .Data); 
            front = front.Next;

        }
        public void Print()
        {
            MyNode = front;
            if (front  == null)
                Console.WriteLine("Queue is Empty");
            else
            {
                
                while (MyNode != null)
                {

                    Console.WriteLine(MyNode   .Data);
                    MyNode   = MyNode  .Next ;

                }
            }

        }
       

    }
}
