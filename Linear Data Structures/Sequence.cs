using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Data_Structures
{
    internal class Sequence
    {
        public static void Main(string[] args)
        {
            /* 
            S1= N;
            S2= S1+ 1;
            S3= 2*S1+ 1;
            S4= S1+ 2;
            S5= S2+ 1;
            S6= 2*S2+ 1;
            S7= S2+ 2;
            */
            Queue<int> mainQueue = new Queue<int>();

            int N = int.Parse(Console.ReadLine());
            mainQueue.Enqueue(N);

            while(true)
            {
                if (mainQueue.Count >= 50)
                {
                    break;
                }
                int M = mainQueue.Peek();

                int S = (M + 1);
                mainQueue.Enqueue(S);
                Console.WriteLine(S);

                int S2 = (2 * M) + 1;
                mainQueue.Enqueue(S2);
                Console.WriteLine(S2);

                int S3 = (M + 2);
                mainQueue.Enqueue(S3);
                Console.WriteLine(S3);

                mainQueue.Dequeue();
            }
        }
    }
}
