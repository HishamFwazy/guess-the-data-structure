using System;

namespace Guess_Data_Structure_LL
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool is_S = true, is_Q = true;
            QueueLL<int> QLL = new QueueLL<int>();
            StackLL<int> SLL = new StackLL<int>();
            Console.WriteLine("Enter Size");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Now ,Enter Data --> ");
               int data = int.Parse(Console.ReadLine());
                QLL.EnQueueLL(data);
                SLL.push(data);



            }
            Console.WriteLine("1-If You Want To Remove  The First Element,then Press 1 ");
            Console.WriteLine("\t\t******************************");

            Console.WriteLine("\t2-If You Want To Remove  The Last Element , then Press 2 ");
            while (true)
            {

                int k = int.Parse(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        QLL.DequeueLL();

                        Console.WriteLine("The Display After Your Operation Will Be ");
                        QLL.Print();

                        Console.WriteLine("\n\t That Mean The Structure is **Queue** List");
                       
                        break;
                    case 2:

                        SLL.pop();
                        Console.WriteLine("The Display After Your Operation Will Be ");
                        SLL.print();
                        Console.WriteLine("\n\t That Mean The Structure is **Stack** List");
                        break;


                    default:
                        Console.WriteLine("Please Try Again ");
                        break;
                }
            }
         }
    }
}
