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

            //Console.CursorVisible = false;
            //Console.SetCursorPosition(1, 1);

            //for (int i = 0; i < 100; i++)
            //{
            //    for (int l = 0; l < i; l++)
            //    {

            //        Console.Write("*");

            //    }

            //    Console.Write(i + "/100");
            //    Console.SetCursorPosition(1, 1);
            //    System.Threading.Thread.Sleep(50);


            //}

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

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("I'm an AI program that wants to learn more about students. \n");
                Thread.Sleep(1000);
                Console.WriteLine("If you have the time could you please answer some questions? \n");
                Thread.Sleep(1000);       
                Console.WriteLine("\nFirst question, what is your name?");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                name = Console.ReadLine();

                string attend = " ";
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\n{name} do you attend most of your classes Y/N");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                attend = Console.ReadLine();
                attend = attend.ToLower();

                if (attend == "y")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Well done on your time managment {name}");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\nWhy do you think this is?\n ");
                    Thread.Sleep(1000);
                    Console.WriteLine("Choose option 1, 2 or 3");
                    Thread.Sleep(500);
                    Console.WriteLine("\n[1] I find it hard to follow my schedule\n");
                    Thread.Sleep(1000);
                    Console.WriteLine("\n[2] I don't enjoy them\n");
                    Thread.Sleep(1000);
                    Console.WriteLine("\n[3] Another Reason\n");
                    int user = Convert.ToInt32(Console.ReadLine());

                    switch (user)
                    {                        
                        case 1:
                            Console.WriteLine("A possible solution is...");
                            Thread.Sleep(1000);
                            Console.WriteLine("\nPrinting out your schedule or keep a copy of it on your phone. ");
                            Thread.Sleep(3000);
                            break;
                        case 2:
                            Console.WriteLine("A possible solution is...");
                            Thread.Sleep(1000);
                            Console.WriteLine("\nCondition yourself by having a yummy treat every class");
                            Thread.Sleep(3000);
                            break;
                        case 3:
                            Console.WriteLine("\nCould you please specify?\n");
                            string specify = Console.ReadLine();
                            Console.WriteLine("\nThank you, if you don't mind I have a few more questions");
                            Thread.Sleep(3000);
                            break;
                    }
                    Console.Clear();
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please enter your age\n");
                Console.ForegroundColor = ConsoleColor.DarkCyan;               
                userage = Convert.ToInt32(Console.ReadLine());

                string hear = "";
                string achievement = "";
                string location = "";
                string time = "";
                string environment = " ";
                string personal = " ";

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nWhere did you hear about Otago Polytech\n");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                hear = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nWhat is your greatest achievement there so far?\n");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                achievement = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nHave you travelled?\n");
                string travel = " ";
                travel = Console.ReadLine();
                travel = travel.ToLower();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nWould you say travelling was good for your personal development? Y/N");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    personal = Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nHow long have you been at " + location + "?");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    time = Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nWould you say it was a nice environment" + time + " ?");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    environment = Console.ReadLine();
                    Console.Clear();
                    Thread.Sleep(1000);
                }

                Console.WriteLine("Have you been overseas before?");
                string checktravel = " ";
                checktravel = Console.ReadLine();
                checktravel = checktravel.ToLower();

                if ((checktravel=="y")||(travel != "y"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nSorry I thought you said you hadn't travelled. My mistake, I will update my records");
                    Thread.Sleep(1000);
                }

                else if ((checktravel !="y")||(travel=="y"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nSorry I thought you said you hadn't travelled. My mistake, I will update my records");
                    Thread.Sleep(1000);
                }
                

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nWhat are you currently Studying?: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string currentStudy = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\nHow long have you been Studying {currentStudy} at Otago Polytech so far?: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nWhat do you enjoy most about studying?: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nWhat has been the biggest learning point in your studies so far?");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.ReadLine();

                Console.WriteLine("Thank you very much, I'll now ask a few more questions if thats alright");
                Console.Clear();
                Thread.Sleep(1000);
                

                //*interacting questions*
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("What is the highlight of your study so far?");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                string highlight = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nWhat are your goals?");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\nWhat part of acheving {highlight} did you enjoy the most?");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.ReadLine();

                Console.WriteLine("Thank you very much, I'll now ask a few more questions if thats alright");
                Console.Clear();
                Thread.Sleep(1000);

                //Previous Study Questions

                //*interacting questions*
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nWhat is your hightest qualification?");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                string highQal = Console.ReadLine();

                Console.WriteLine("Thank you very much, I'll now ask a few more questions if thats alright");
                Console.Clear();
                Thread.Sleep(1000);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Do you think getting your {highQal} prepared you for your studies in {currentStudy}?: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.ReadLine();

                //Questions that depend on prev answer
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nDo you have any Learning Disabilities? Y/N");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                string learnDis = Console.ReadLine();
                learnDis = learnDis.ToLower();

                if (learnDis == "yes")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nDid this impact your study? Y/N ");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nDo you have help so you are able to do your best? Y/N ");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nDo you know anyone with a Learning Disability. Y/N ");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.ReadLine();
                }

                Console.WriteLine("Thank you very much, I'll now ask a few more questions if thats alright");
                Console.Clear();
                Thread.Sleep(1000);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Do you have children? Y/N");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                string kids = Console.ReadLine();
                kids = kids.ToLower();
                if (kids == "yes")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nDoes it have a large impact on your time management while studying? Y/N ");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Thank you, I'll now ask a few more questions if thats alright");
                    Console.Clear();
                    Thread.Sleep(1000);
                }

                //Report inconsistancies
                string commitments = " ";

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nDo you have commitments outside of study? Y/N ");
                commitments = Console.ReadLine();
                commitments = commitments.ToLower();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.ReadLine();

                string hobbies = " ";
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Do you have any hobbies?");
                hobbies = Console.ReadLine();
                hobbies = hobbies.ToLower();

                if ((hobbies != "y")|| (commitments == "y"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Sorry I thought you said you didn't have any commitments. My mistake, I will update my records");
                    Thread.Sleep(1000);
                }
                else if ((hobbies == "y")||(commitments != "y"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Sorry I thought you said you didn't have any commitments. My mistake, I will update my records");
                    Thread.Sleep(1000);
                }

                if ((hobbies == "y")|| (commitments == "y"))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("What types of things do you do in your time outside of class?");
                    string activies = Console.ReadLine();
                    Thread.Sleep(1000);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Are you able to balance your study with {activies}? Y/N");
                    string balance = " ";
                    balance = Console.ReadLine();
                }

                Console.WriteLine("Thank you very much, you are 70% of the way through the questions");
                Console.Clear();
                Thread.Sleep(1000);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nDid you have a gap between finishing high school and tertiary study? Y/N ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                string gapYear = Console.ReadLine();
                gapYear = gapYear.ToLower();

                if (gapYear == "yes")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nDid you work?");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    string work = Console.ReadLine();
                    work = work.ToLower();

                    if (work == "yes")
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nDid that lead to your current Study?: ");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nDid the Gap year benefit you?: ");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.ReadLine();
                    }
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nIf your were to go back would you take a gap year?: ");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.ReadLine();
                    Console.Clear();
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
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nThank you very much, the answers to your questions are very helpful. ");
                Thread.Sleep(1000);
                    Console.WriteLine("\nIf you would like to change any of your answers you may do so now.");
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
