using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = 8, c = 8;
            char nextLetter = 'X';
            char otherLetter = 'O';
            char cPrintLetter = nextLetter;

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {

                    cPrintLetter = nextLetter;
                    if (j < (c - 1))
                    {

                        Console.Write(cPrintLetter);
                        nextLetter = otherLetter;
                        otherLetter = cPrintLetter;
                    }
                    else
                    {
                        Console.WriteLine(cPrintLetter);
                    }
                }
            }
            Console.Read();
        }
    }
}