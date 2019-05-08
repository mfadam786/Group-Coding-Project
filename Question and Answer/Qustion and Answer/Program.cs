using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace Qustion_and_Answer
{
    class Program
    {
        static void Main(string[] args)
        {/*
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

            */
         //Faizel: added this part


            int count = 1, max = 10;

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("hello");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("HI");

                if (max - count == 3)
                {
                    max = max * 10;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(count);
                
                count++;

            } while (count < max);

            Console.ReadLine();
            /*
            
               Stopwatch stopWatch = new Stopwatch();
               stopWatch.Start();
               Thread.Sleep(100000);

               TimeSpan checkTime = stopWatch.Elapsed;
               //checkTime.Minutes.Equals(01);


               //checkTime.ToString() == string.Format("{0:00}:{1:00}:{2:00}.{3:00}", checkTime.Hours, checkTime.Minutes, checkTime.Seconds, checkTime.Milliseconds / )

               if (checkTime.Hours.Equals(00) && checkTime.Minutes.Equals(00) && checkTime.Seconds.Equals(30) && checkTime.Milliseconds.Equals(00))
               {
                   Console.ForegroundColor = ConsoleColor.Red;
                   Console.WriteLine("Well, thak you {name}, but we have almost reached the end of our interview ");
               }



               TimeSpan ts = stopWatch.Elapsed;// Get the elapsed time as a TimeSpan value.

               // Format and display the TimeSpan value.
               string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                   ts.Hours, ts.Minutes, ts.Seconds,
                   ts.Milliseconds / 10);
               Console.WriteLine("RunTime " + elapsedTime);
               stopWatch.Stop();
               Console.ReadLine();
               
            /*
               //Kevin code those

               string position = "";
               string achievement = "";
               string company = "";
               string time = "";
               string environment = "";

               Console.WriteLine("Where did you hear about the position?");
               position = Console.ReadLine();

               Console.WriteLine("What is your greatest professional achievement?");
               achievement = Console.ReadLine();

               Console.WriteLine("Which company did you got the " + achievement + " ?");
               company = Console.ReadLine();

               Console.WriteLine("How long did you work in " + company + "?");
               time = Console.ReadLine();

               Console.WriteLine("What kind of work environment did you work last "+ time+" ?");
               environment = Console.ReadLine();



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

               */
            //
            //Georgettes Section










            //
        } //Faizel: Added a comment for no reason whatsoever

    }
}
