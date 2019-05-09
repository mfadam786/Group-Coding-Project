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
        {
            string answer;

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

            do
            {
                Console.WriteLine("How long did you work in " + company + "?");
                time = Console.ReadLine();

                Console.WriteLine("What kind of work environment did you work last " + time + " ?");
                environment = Console.ReadLine();


                Console.WriteLine("So you worked at " + company + " for " + time + " right?");
                answer = Console.ReadLine();
            }
            while (answer != "yes");



            //Bernies Section- To do The “AI” picks up on inconsistent answers 
            //(e.g. if the user answers one question with a yes and later contradicts this, the AI will respond accordingly)

            string name, attend = " ";


            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            Console.WriteLine("Do you attend all of you classes ");
            attend = Console.ReadLine();
            attend = attend.ToLower();

            if (attend == "Y")
            {
                Console.WriteLine("Does this help you grades?");
            }
            else
            {
                Console.WriteLine("Why is this?");
                Console.WriteLine("\n[1] Too little information");
                Console.WriteLine("\n[2] Too any commitments");
                Console.WriteLine("\n[3] Other");
                int user = Convert.ToInt32(Console.ReadLine());

                switch (user)
                {
                    case 1:
                        Console.WriteLine("That sucks");
                        break;
                    case 2:
                        Console.WriteLine("You should make mmore time for yourself");
                        break;
                    case 3:
                        Console.WriteLine("Please specify:");
                        string specify = Console.ReadLine();
                        break;
                }
            }

            Console.ReadLine();


            
            //Georgettes Section
            //Job Questions
            Console.Write("What are you currently Studying?: ");
            string currentStudy = Console.ReadLine();

            Console.Write($"How long have you been Studying {currentStudy} at Otago Polytech so far?: ");
            Console.ReadLine();

            Console.Write("Bigest learning point in your study so far?: ?");
            Console.ReadLine();

            Console.Write("What do you enjoy about studying?: ");
            Console.ReadLine();

            Console.Write("What are your goals?");
            Console.ReadLine();

            //*interacting questions*
            Console.Write("What is the hilight of your study so far?");
            string hilight = Console.ReadLine();

            Console.Write($"What made the hilight {hilight} so memrable?");
            Console.ReadLine();

            //Previous Study Questions

            //*interacting questions*
            Console.Write("What is your hightest qualification?");
            string highQal = Console.ReadLine();

            Console.Write($"Did {highQal} prepare you for your studies in {currentStudy}?: ");
            Console.ReadLine();    
        
        //Qusetions that depend on prev answer
        Console.Write("Do you have any Learning Disablities?: yes/no");
            string learnDis = Console.ReadLine();
            learnDis = learnDis.ToLower();
            if (learnDis == "yes")
            {
                Console.Write("Did this impact your study?: ");
                Console.ReadLine();

                Console.Write("Do you have help so you are able to do your best?: ");
                Console.ReadLine();
            }
            else
            {
                Console.Write("Do you know anyone with a Learning Disablitie: ");
                Console.ReadLine();
            }

            Console.Write("Do you have kids?: yes/no");
            string kids = Console.ReadLine();
            kids = kids.ToLower();
            if (kids == "yes")
            {
                Console.Write("Dose it have a large impact on your time managemnet while studying?: ");
                Console.ReadLine();
            }
            else
            {
		    //bernie We could put your hobbie questions here
                Console.Write("Do you have commitments outside of study?: ");
                Console.ReadLine();
            }

            Console.Write("Did you have a gap year (or multiple)?: yes/no");
            string gapYear = Console.ReadLine();
            gapYear = gapYear.ToLower();

            if (gapYear == "yes")
            {
                Console.Write("Did you work?: yes/no");
                string work = Console.ReadLine();
                work = work.ToLower();
                if (work == "yes")
                {
                    Console.Write("Did that lead to your current studies?: ");
                    Console.ReadLine();
                }
                else
                {
                    Console.Write("Did the Gap year benifit you?: ");
                    Console.ReadLine();
                }
            }

            else
            {
                Console.Write("If your were to go back would you take a gap year?: ");
                Console.ReadLine();                
            }

            /////////////////////////////////////////////////////Faizel's section//////////////////////////////////////////////////////////////////////////////////
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
