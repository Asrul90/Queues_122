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

            }
        }
        static void Main(string[] args)
        {
        }
    }
}
