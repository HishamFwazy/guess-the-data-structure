using System;
using System.Collections.Generic;
using System.Text;

namespace Guess_Data_Structure_LL
{
    class StackLL<T>
    {

        public Node<T>top=null , MyNode;
        public int count = 0;

        public int size()
        {
            return count;

        }

        public bool isEmpty
        {
            get
            {
                return count == 0;
            }
        }

        public T peek()
        {
            if (isEmpty)
            {
                throw new Exception("ListStackEmptyException");
            }
            return top .Data;
        }


        public void print()
        {
            Node<T> Mynode = top;
            if (top == null)
            {
                Console.WriteLine("Stack is empty");

            }
            else
            {
                // T value = head.Data;
                //Console.WriteLine(value);
                //NodeS<T> temp = head;
                while (Mynode  != null)
                {

                    Console.WriteLine(Mynode .Data);
                    Mynode  = Mynode .Next;

                }
            }
        }

        public void push(T value)
        {
            if (top == null)
            {
                top = new Node<T>(value);
            }

         else
            {
                MyNode = new Node<T>(value  );
                MyNode.Next = top;
                top = MyNode;
            }
           
        }

        public void pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack UnderFlow");

            }
            else
            {
                Console.WriteLine("The PoP Element ="+top.Data);
                top = top.Next;
            }
        }
    }
}
