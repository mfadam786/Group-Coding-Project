using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qustion_and_Answer
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is where wer start coding
	    //
	    //difine the variables
            int witch, heads = 0, tails = 0, i;
            //char headsH, tailsT;

            Random rand = new Random();

            //for loop

            for (i =1; i < 1001; i++)
            {
                witch = rand.Next(2);
                if (witch == 1)
                {
                    heads = heads + 1;
                }
                else
                {
                    tails = tails + 1;
                }

            }

            //displays the amount of times H and the amount of times T was thrown

            Console.WriteLine($"heads has been fliped = {heads} times. Tails tails has been fliped = {tails} times.");
            Console.ReadLine();
        }
    }
}
