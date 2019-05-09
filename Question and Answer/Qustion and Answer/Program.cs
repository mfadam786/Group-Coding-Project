using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace Qustion_and_Answer
{
    class Program
    {
        static void Main(string[] args)
        {/*
            /////////////////FAIZEL: created this never ending do while loop///////////////////////////
            int count = 1, max = 10;

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" hello ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" HI ");

                if (max - count == 3)
                {
                    max = max * 10;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(count);

                count++;

            } while (count < max);

            Console.ReadLine();
            ///////////////////////////////////////////////////////////////////////////////////////
            /*
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

               
            //
            //Georgettes Section
            //Job Questions
            Console.Write("What is your current Job?");
            Console.ReadLine();

            Console.Write("How long have you been working in your current job?");
            Console.ReadLine();

            Console.Write("Bigest learning point in your career?");
            Console.ReadLine();

            Console.Write("What do you enjoy about your job?");
            Console.ReadLine();

            Console.Write("What are your goals?");
            Console.ReadLine();

            //*interacting questions*
            Console.Write("What is the hilight of your carrer?");
            string hilight = Console.ReadLine();

            Console.Write($"What made the hilight {hilight} so memrable?");
            Console.ReadLine();

            //Previous Study Questions

            //*interacting questions*
            Console.Write("What is your hightest qualification?");
            string highQal = Console.ReadLine();

            Console.Write($"Did {highQal} prepare you for your current carreer?");
            Console.ReadLine();

            */

            /////////////////////////////////////////////////////Faizel's section//////////////////////////////////////////////////////////////////////////////////
            
            string name = "MF";
            int hours, mins, seconds, milliseconds;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Thread.Sleep(15000);

            TimeSpan checkTime = stopWatch.Elapsed;

            hours = checkTime.Hours;
            mins = checkTime.Minutes;
            seconds = checkTime.Seconds;
            milliseconds = checkTime.Milliseconds;

            if (checkTime.Hours.Equals(hours) && checkTime.Minutes.Equals(mins) && checkTime.Seconds.Equals(seconds) && checkTime.Milliseconds.Equals(milliseconds))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Well, thak you {name}, but we have almost reached the end of our interview, just 2 more questions");
            }

            Console.ReadLine();

            //string checkElapsed = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", checkTime.Hours, checkTime.Minutes, checkTime.Seconds, checkTime.Milliseconds / 10);
            
            stopWatch.Start();
            Thread.Sleep(10000);

            TimeSpan ts = stopWatch.Elapsed;// Get the elapsed time as a TimeSpan value.
            stopWatch.Stop();
            
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);// Format and display the TimeSpan value.

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\nRunTime : ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(elapsedTime);            
            Console.ReadLine();

    /*
            string positive_Words, unknown_Words, negative_Words;
            int countP = 0, countN = 0, countU = 0;

            StreamReader positive = new StreamReader(@"H:\Group-Coding-Project\Question and Answer\Positive.txt");
            positive_Words = positive.ReadLine().ToUpper();
            positive.Close();


            StreamReader negative = new StreamReader(@"H:\Group-Coding-Project\Question and Answer\Negative.txt");
            negative_Words = negative.ReadLine().ToUpper();
            negative.Close();


            StreamReader unknown = new StreamReader(@"H:\Group-Coding-Project\Question and Answer\Unknown.txt"); 
            unknown_Words = unknown.ReadLine().ToUpper();
            unknown.Close();            

            string[] positive_Check = positive_Words.Split(',');
            string[] unknown_Check = unknown_Words.Split(',');
            string[] negative_Check = negative_Words.Split(',');

            string temp = Console.ReadLine().ToUpper();

            foreach (string yes in positive_Check)
            {
                if (temp == yes)
                {                    
                    countP++;
                }

                //Console.ForegroundColor = ConsoleColor.Magenta;
                //Console.WriteLine(yes);
            }  

            temp = Console.ReadLine().ToUpper();

            foreach (string maybe in unknown_Check)
            {
                if (temp == maybe)
                {
                    countU++;
                }
            }

            temp = Console.ReadLine().ToUpper();

            foreach (string no in negative_Check)
            {
                if (temp == no)
                {
                    countN++;
                }
            }


            if (countP > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("That is positive");
            }

            if (countU > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("That is unknown");
            }

            if (countN > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That is negative");
            }
            Console.ReadLine();*/
            /////////////////////////////////////////////////////Faizel's section//////////////////////////////////////////////////////////////////////////////////
        }

    }
}
