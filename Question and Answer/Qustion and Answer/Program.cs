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

            Console.Write("Bigest learning point in your carrer?");
            Console.ReadLine();

            Console.Write("What do you enjoy about your job?");
            Console.ReadLine();

            Console.Write("What are your goals?");
            Console.ReadLine();

            //*interacting questions*
            Console.Write("What is the hilight of your carrer?");
            hilight = Console.ReadLine();

            Console.Write($"What made the hilight {hilight} so memrable?");
            Console.ReadLine();

            //Previous Study Questions

            //*interacting questions*
            Console.Write("What is your hightest qualification?");
            highQal = Console.ReadLine();

            Console.Write($"Did {highQal} prepare you for your current carreer?");
            Console.ReadLine();

//Qusetions that depend on prev answer
            Console.Write("Do you have kids?: ");
            string kids = Console.ReadLine();
            if (kids == "yes")
            {
                Console.Write("Dose it have a large impact on your time managemnet?: ");
                Console.ReadLine();
            }
            else
            {
                Console.Write("Do you have any pets?: ");
                Console.ReadLine();
            }

            Console.Write("Did you have a gap year (ir two)?: ");
            string gapYear = Console.ReadLine();
            if (gapYear == "yes")
            {
                Console.Write("Did you work?");
                string work = Console.ReadLine();
                if (work == "yes")
                {
                    Console.Write("Did that lead to your current job?: ");
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








            //
        } //Faizel: Added a comment for no reason whatsoever

    }
}
