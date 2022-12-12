using System;
using System.Collections.Generic;
using System.Linq;
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

        }
        static void Main(string[] args)
        {
        }
    }
}
