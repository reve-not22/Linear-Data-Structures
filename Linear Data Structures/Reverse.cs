namespace Linear_Data_Structures
{
    internal class Reverse
    {
        public static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                char[] delims = { ',', ' ', '.' };
                Stack<int> numStack = new Stack<int>();
                Console.WriteLine("Input any number of integers (q to quit)");
                string input1 = Console.ReadLine();

                if (input1 == "q" || input1 == "quit")
                {
                    break;
                }

                string[] intList = input1.Split(delims);
                foreach (string str in intList)
                {
                    numStack.Push(int.Parse(str));
                }

                while (numStack.Count > 0)
                {
                    Console.WriteLine(numStack.Pop());
                }
            }
        }
    }
}

