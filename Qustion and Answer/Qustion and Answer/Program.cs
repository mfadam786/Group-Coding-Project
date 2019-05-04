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
            //This is where we start coding
	    
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


	    //Faizel: added this part

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


        //Kevin code those
       
            for (int z = 1; z < 10; z++) {
                for (int s = 1; s <= z; s++) {
                    Console.Write(s + "*" + z + "=" + z * s + " ");
                    if (z == s) {
                        Console.Write("\n");
                    }
                }
            }
            Console.ReadKey();
        //Bernies Section
        

















            //
            //Georgettes Section











            //
        } //Faizel: Added a comment for no reason whatsoever

    }
}
