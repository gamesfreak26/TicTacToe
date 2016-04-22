using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Board
    {
        int[] numbers = new int[9];

        public void DrawBoard()
        { 

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("\n|\t 0 \t|\t 1 \t|\t 2 \t|\n");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("\n|\t 3 \t|\t 4 \t|\t 5 \t|\n");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("\n|\t 6 \t|\t 7 \t|\t 9 \t|\n");
            Console.WriteLine("------------------------------------------------");
            Console.ReadLine();
        }
    }
}
