using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Queues_122
{
    class Program
    {
        int FRONT, REAR, max = 5;
        int[] queue_array= new int[5];

        public Program()
        {
            /*intializin the value of the variable RAEAR and FRONT to -1 to indicate that
             * the queue is initially empty*/
            FRONT = -1;
            REAR = -1;
        }

        public void insert(int element)
        {
            /* this statement cheks for the over flow condition */
            if ((FRONT == 0 && REAR == max -1 ) ||(FRONT == REAR + 1))
            {
                Console.WriteLine("\nQueue overflow\n");
                return;
            }
            /* this following statement checks whether the queue is empty. if the queue is empty
             * then the value of the REAR and FRONT variables is set to 0*/

            if (FRONT == -1)
            {
                FRONT= 1;
                REAR = 1;
            }
            else
            {
                /* if rear is at the llast position of the array, then the value of 
                 * rear is set to 0 that corresponds to the first position of the array. */
                if (REAR == max -1)
                    REAR= 0;
                else
                    /* if rear is not at the last position then is value is incremented by one */
                    REAR = REAR +1;
            }
            /* once the position of rear is determined, the element is added at its proper place */
            queue_array[REAR] = element;
        }
        public void remove()
        {
            /* cheks wheather the queue is empty. */
            if (FRONT == -1)
            {
                Console.WriteLine("queue underflow\n");
                return;
            }
            Console.WriteLine("\nThe element deeted from the queue is: " + queue_array[FRONT] 
                + "\n");
            /* Check is the queue has one element. */
            if (FRONT == REAR)
            {
                FRONT= -1;
                REAR= -1;
            }
            else
            {
                /* if the element to be deleted is at the last position of the array, then the value 
                 * of front is set to 0 i.e to the first element of the array. */
                if (FRONT == max -1)
                    FRONT = 0;
                else
                {
                    /* front is icremeted by one if it is not the first elemnt of array. */
                    FRONT = FRONT+1;
                }
            }

            
        }
        public void display()
        {
            int FRONT_position = FRONT;
            int REAR_position = REAR;
            /* checks if the queue is empty. */
            if (FRONT == -1)
            {
                Console.WriteLine("queue is empty\n");
                return;

            }
            Console.WriteLine("\nElement is the queue are ................\n");
            if (FRONT_position <=REAR_position)
            {
                /* traverse the queue till the last element present in an array. */
                while (FRONT_position < REAR_position)
                {
                    Console.WriteLine(queue_array[FRONT_position] + "    ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
            else
            {
                /* treverse the queue till the last position of the array. */
                while (FRONT_position <= max - 1)
                {
                    Console.WriteLine(queue_array[FRONT_position] + "    ");
                    FRONT_position++;
                }
                /* se the front position to the first element of the array. */
                FRONT_position = 0;
                /* traverse the array till the last element present in the queue. */
                while (FRONT_position <= REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + "    ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Program queue = new Program();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("menu");
                    Console.WriteLine("1. implement isert operation");
                    Console.WriteLine("2. implement delete operation");
                    Console.WriteLine("3. display values");
                    Console.WriteLine("4. exit");
                    Console.Write("\n enter your choice (1-4): ");
                    ch = Convert.ToChar(Console.Read());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                Console.Write("enter a number:  ");
                                int num = Convert.ToInt32(System.Console.ReadLine());
                                Console.WriteLine();
                                queue.insert(num);

                            }
                            break;
                        case '2':
                            {
                                queue.remove();
                            }
                            break;
                        case '3':
                            {
                                queue.display();
                            }
                            break;
                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("invalid option !!");
                            }
                            break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(" check the values entered.");
                }
            }
        }
    }
}
