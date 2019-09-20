using System;

namespace Deliverable_3_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            try
                { int size = 25;
                int[] elements = new int[size];
                for (int i = 0; 
                    i <= 25; i++)
                {
                    elements[i] = i + 1;
                    Console.Write(" Vaule Of Element = " + elements[i]);

                }
            }
            catch
            {
                Console.ReadLine();
            }
        }
    }
}
