using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Data_Structures
{
    internal class FindAmountInArray
    {
        public static void Main(string[] args)
        {
            int[] myArray = { 10, 5, 20, 5, 20, 131, 6, 6, 6 };
            List<int> prohibitedMembers = new List<int>();

            foreach(int i in myArray)
            {
                int duplicateCount = 0;
                bool doLoop= true;

                foreach(int member in prohibitedMembers)
                {
                    if (member == i)
                    {
                        doLoop = false;
                    }
                }
                if (doLoop)
                {
                    foreach (int j in myArray)
                    {
                        if (i == j)
                        {
                            duplicateCount++;
                        }
                    }
                    if (duplicateCount > 1)
                    {
                        Console.WriteLine(i + ": " + duplicateCount + " Times");
                        prohibitedMembers.Add(i);
                    }
                }
            }
        }
    }
}
