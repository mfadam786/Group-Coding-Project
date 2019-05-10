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
            Console.WriteLine("Connecting Database...");

            Console.CursorVisible = false;
            Console.SetCursorPosition(1, 1);

            for (int i = 0; i < 100; i++)
            {
                for (int l = 0; l < i; l++)
                {

                    Console.Write("*");

                }

                Console.Write(i + "/100");
                Console.SetCursorPosition(1, 1);
                System.Threading.Thread.Sleep(50);


            }

            Console.Clear();
            Console.Write("Connect successful");
            System.Threading.Thread.Sleep(500);
            Console.Clear();

            string answer;

            /////////////////FAIZEL: created this never ending do while loop///////////////////////////
            /////Add in pet specifications 
            ///
            int count = 1, max = 10;

            do
            {

                string temp, name;
                int userage;

                Console.ForegroundColor = ConsoleColor.DarkCyan;

                Console.WriteLine("I'm an AI program that wants to learn more about students. Please aswer some questions about your studies ");
                Thread.Sleep(1000);
                Console.WriteLine("It should not take longer than 5 mins to answer all of the questions the I have for you.\r");
                Thread.Sleep(1000);
                Console.WriteLine("\nWhat is your name?");
                name = Console.ReadLine();

                string attend = " ";
                Console.WriteLine($"{name} do you attend all of you classes Y/N");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                attend = Console.ReadLine();
                attend = attend.ToLower();

                if (attend == "y")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"Well done on your time managment {name}");
                    Thread.Sleep(3000);
                }
                else
                {
                    Console.WriteLine("Why is this?\n ");
                    Console.WriteLine("Choose option 1, 2 or 3");
                    Thread.Sleep(500);
                    Console.WriteLine("\n[1] I find it hard to follow/remember my schedule\n");
                    Console.WriteLine("\n[2] I have too much to do\n");
                    Console.WriteLine("\n[3] Other\n");
                    int user = Convert.ToInt32(Console.ReadLine());

                    switch (user)
                    {
                        case 1:
                            Console.WriteLine("\nYou could try printing out your schedule or keep a photo on your phone. ");
                            Thread.Sleep(3000);
                            break;
                        case 2:
                            Console.WriteLine("\nYou should make more time for yourself. Try using a calander app to track where you need to be");
                            Thread.Sleep(3000);
                            break;
                        case 3:
                            Console.WriteLine("\nPlease specify:\n");
                            string specify = Console.ReadLine();
                            Console.WriteLine("Thank you, if you don't mind I have a few more questions");
                            Thread.Sleep(3000);
                            break;
                    }
                    Console.Clear();
                }
                Console.WriteLine("Please enter your age");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                temp = Console.ReadLine();
                userage = Convert.ToInt32(temp);

                string hear = "";
                string achievement = "";
                string location = "";
                string time = "";
                string environment = " ";
                string personal = " ";

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Where did you hear about Otago Polytech");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                hear = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("What is your greatest achievement there?");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                achievement = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Have you travelled?");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Would you say travelling was good for your personal development? Y/N");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    personal = Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("How long have you been at " + location + "?");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    time = Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Would you say it was a nice environment" + time + " ?");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    environment = Console.ReadLine();
                }
                Console.Clear();
                Thread.Sleep(1000);

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("What are you currently Studying?: ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                string currentStudy = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"How long have you been Studying {currentStudy} at Otago Polytech so far?: ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("What do you enjoy most about studying?: ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("What has been the biggest learning point in your studies so far?");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.ReadLine();

                Console.Clear();
                Thread.Sleep(1000);

                //*interacting questions*
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("What is the highlight of your study so far?");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                string highlight = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("What are your goals?");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"What made the highlight {highlight} so memorable?");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.ReadLine();

                //Previous Study Questions

                //*interacting questions*
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("What is your hightest qualification?");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                string highQal = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"Did {highQal} prepare you for your studies in {currentStudy}?: ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.ReadLine();

                //Qusetions that depend on prev answer
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Do you have any Learning Disabilities?: yes/no");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                string learnDis = Console.ReadLine();
                learnDis = learnDis.ToLower();

                if (learnDis == "yes")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Did this impact your study?: ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Do you have help so you are able to do your best?: ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Do you know anyone with a Learning Disability: ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.ReadLine();
                }

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Do you have children?: Y/N");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                string kids = Console.ReadLine();
                kids = kids.ToLower();
                if (kids == "yes")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Does it have a large impact on your time management while studying?: ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.ReadLine();
                }
                else
                {
                    //bernie We could put your hobbie questions here
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Do you have commitments outside of study?: ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.ReadLine();
                }
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Did you have a gap year or two?: ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                string gapYear = Console.ReadLine();
                gapYear = gapYear.ToLower();

                if (gapYear == "yes")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Did you work?");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    string work = Console.ReadLine();
                    work = work.ToLower();

                    if (work == "yes")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Did that lead to your current Study?: ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Did the Gap year benefit you?: ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.ReadLine();
                    }
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("If your were to go back would you take a gap year?: ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
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
                ///
                string again = " ";
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Thank you very much, the program will now run again");
                again = Console.ReadLine();
                again = again.ToLower();
                Thread.Sleep(1000);

                if (max - count == 3)
                {
                    max = max * 10;
                }

                count++;

            } while (count < max);


            Console.ReadLine();

            /////////////////////////////////////////////////////Faizel's section//////////////////////////////////////////////////////////////////////////////////
            ///

            /////////////////////////////////////////////////////Faizel's section//////////////////////////////////////////////////////////////////////////////////

        }
    }
}
