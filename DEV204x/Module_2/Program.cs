using System;

namespace Module_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    //Both row and column order are even, then write X
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        Console.Write("X");
                    }
                    //Both row and column order are odd, then write X
                    else if (i % 2 != 0 && j % 2 != 0)
                    {
                        Console.Write("X");
                    }
                    //Row is even column odd or vice versa
                    else
                    {
                        Console.Write("O");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
