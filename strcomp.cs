using System;

namespace stringcompression
{
    class Program
    {
        static void Main(string[] args)
        {
            string uncompressed = Console.ReadLine();
            // read from STDIN
            string compressed = "";
            // set equal to empty string for now
            int counter = 0;
            // keep track of current character count;
            char current = uncompressed[0];
            // keep track of current char
            for (int i = 0; i < uncompressed.Length; i++)
            {
                //Console.WriteLine("Diagnostic: " + uncompressed[i]);
                if (i == uncompressed.Length - 1)
                {
                    compressed += (counter + 1).ToString();
                    compressed += current;
                    current = uncompressed[i];
                }
                else if (current != uncompressed[i])
                {
                    compressed += counter.ToString();
                    compressed += current;
                    current = uncompressed[i];
                    counter = 1;
                }
                else
                {
                    counter++;
                }
            }
        }
    }
}
