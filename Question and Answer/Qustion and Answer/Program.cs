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
            //Need to work out how to compare the year they were born with this year minus their age
            string temp;
            int DOB, userage;

            Console.WriteLine("What year were you born?");        //Split method to compare their age to the year they were born
            temp = Console.ReadLine();
            DOB = Convert.ToInt32(temp);

            Console.WriteLine("Please enter your age");
            temp = Console.ReadLine();
            userage = Convert.ToInt32(temp);

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
            //Bernies Section- To do The “AI” picks up on inconsistent answers 
            //(e.g. if the user answers one question with a yes and later contradicts this, the AI will respond accordingly)

            string name,paper=" ";
            int height, height2;

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();         

            Console.WriteLine("What is your height in cm");
            temp = Console.ReadLine();
            height = Convert.ToInt32(temp);           

            Console.WriteLine("How tall are you in cm?");
            temp = Console.ReadLine();
            height2 = Convert.ToInt32(temp);

            if (height!=height2)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Um..excuse me you said you were {height} ");
            }

            Console.WriteLine("Do you read the newspaper?");
            paper = Console.ReadLine();
            paper = paper.ToUpper();



            Console.ReadKey();


            //
            //Georgettes Section











            //
        } //Faizel: Added a comment for no reason whatsoever

    }
}
