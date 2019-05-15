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
            Console.WriteLine("Connecting to Database...");

            Console.CursorVisible = false;
            Console.SetCursorPosition(1, 1);

            for (int i = 0; i < 100; i++)
            {
                for (int l = 0; l < i; l++)
                {

                    Console.Write("*");

                }

                Console.WriteLine(("\n" + i + "/100"));
                Console.SetCursorPosition(1, 1);
                System.Threading.Thread.Sleep(50);


            }

            Console.Clear();
            Console.Write("Connection successful");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            int count = 1, max = 10;
            string choice;

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            do
            {
                string name;
                int userage;
                double calc = 0;

                do
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nPlease enter your date of birth (FORMAT: DD/MM/YYYY)\n");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    string temp = Console.ReadLine();

                    DateTime today_Date = DateTime.Today;

                    TimeSpan date = today_Date.Subtract(Convert.ToDateTime(temp));

                    calc = (date.Days / 365);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nPlease enter your age\n");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    userage = Convert.ToInt32(Console.ReadLine());

                    if (userage == calc)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nThank you, I have verified that your age is correct. Now we can proceed.\n");
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nI'm sorry, but I think you have entered either your age or date of birth incorrectly\n");
                        Console.WriteLine("Please try again\n");
                    }

                } while (calc != userage);

                System.Threading.Thread.Sleep(4000);
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("I'm an AI program that wants to learn more about students.\n");
                Thread.Sleep(1000);
                Console.WriteLine("If you have the time could you please answer some questions?");
                Thread.Sleep(1000);
                Console.WriteLine("\nFirst question, what is your name?");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                name = Console.ReadLine();

                string attend = " ";
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\n{name}, do you attend most of your classes (Y/N)");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                attend = Console.ReadLine();
                attend = attend.ToLower();

                if ((attend == "y") || (attend == "yes"))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"\nWell done on your time management {name}");
                    Thread.Sleep(2500);
                    Console.Clear();
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nWhy do you think this is?");

                    Thread.Sleep(1000);
                    Console.WriteLine("\nChoose option 1, 2 or 3");
                    Thread.Sleep(500);
                    Console.WriteLine("\n[1] I find it hard to follow my schedule");
                    Thread.Sleep(1000);
                    Console.WriteLine("\n[2] I don't enjoy them");
                    Thread.Sleep(1000);
                    Console.WriteLine("\n[3] Another Reason\n");
                    Console.Write("\nChoice: ");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    string temp = Console.ReadLine();
                    int userreason = Convert.ToInt32(temp);


                    switch (userreason)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\nA possible solution is...\n");
                            Thread.Sleep(1000);
                            Console.WriteLine("\nPrinting out your schedule or keep a copy of it on your phone. ");
                            Thread.Sleep(3000);
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\nA possible solution is...");
                            Thread.Sleep(1000);
                            Console.WriteLine("\nCondition yourself by having a yummy treat every class");
                            Thread.Sleep(3000);
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\nCould you please specify?\n");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            string specify = Console.ReadLine();
                            Console.WriteLine("\nThank you, if you don't mind I have a few more questions\n");
                            Thread.Sleep(2000);
                            break;
                    }
                    Console.Clear();
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nWhat are the best methods you have found for retaining information?\n");

                Console.WriteLine("\nChoose option 1, 2, 3 or 4");
                Thread.Sleep(500);
                Console.WriteLine("\n[1] Note taking");
                Thread.Sleep(1000);
                Console.WriteLine("\n[2] Explaining concepts to a classmate");
                Thread.Sleep(1000);
                Console.WriteLine("\n[3] Having concepts explained to me");
                Thread.Sleep(1000);
                Console.WriteLine("\n[4] Flash cards");
                Thread.Sleep(1000);
                Console.Write("\nChoice : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                int user = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                switch (user)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nThere are many different ways people prefer to learn.");
                        Console.WriteLine($"\n{name}, you may be someone that learns best by reading and writing");
                        Thread.Sleep(3000);
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nThere are many different ways people prefer to learn.");
                        Console.WriteLine($"\n{name}, you may be an auditory learner.");
                        Thread.Sleep(3000);
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nThere are many different ways people prefer to learn.");
                        Console.WriteLine($"\n{name}, you may be an auditory learner.\n");
                        Thread.Sleep(2000);
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("There are many different ways people prefer to learn");
                        Console.WriteLine($"\n{name} you may be a kinesthetic learner");
                        break;
                }

                string hear = "";
                string achievement = "";
                string time = "";
                string environment = " ";
                string personal = " ";

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\nWhat institution do you study at?");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                string place = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\nWhere did you hear about {place}?");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                hear = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\nWhat is your greatest achievement at {place} so far?");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                achievement = Console.ReadLine();


                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nHave you travelled? (Y/N)");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                string travel;
                travel = Console.ReadLine();
                travel = travel.ToLower();
                Console.Clear();

                if ((travel == "y") || (travel == "yes"))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nWould you say travelling was good for your personal development? (Y/N)");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    personal = Console.ReadLine();
                    Console.Clear();
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nSorry to be a pain, but I've forgotten, have you been overseas before?");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                string checktravel = " ";
                checktravel = Console.ReadLine();
                checktravel = checktravel.ToLower();

                if ((checktravel == "y") && (travel != "y"))//Your code wasn't running because you had used the OR (||), not the AND (&&) condition here
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nSorry I thought you said you had travelled. My mistake, I will update my records");
                    Thread.Sleep(3000);
                    Console.Clear();
                }

                else if ((checktravel != "y") && (travel == "y"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nSorry I thought you said you hadn't travelled. My mistake, I will update my records");
                    Thread.Sleep(3000);
                    Console.Clear();
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nThank you very much, I'll now ask a few more questions if thats alright");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                               
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nHow long have you been at " + place + "? (Answer in MONTHS)");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                time = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nWould you say it was an enjoyable environment at " + place + " for these " + time + " months?");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                environment = Console.ReadLine();
                Thread.Sleep(700);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nWhat are you currently studying?");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string currentStudy = Console.ReadLine();
                
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\nHow long have you been studying {currentStudy} at {place}? (Answer in MONTHS)");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                string check = Console.ReadLine();

                if (check != time)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nI'm sorry, but didn't you say that you have been at {place}, for {time} when I asked earlier?");
                    System.Threading.Thread.Sleep(3500);
                    Console.WriteLine($"\nIs it \n\n[1] {time}\n\n or \n\n[2] {check}\n\nChoice: ");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    int change = Convert.ToInt32(Console.ReadLine());

                    switch(change)
                    {
                        case 1:
                            time = time;
                            break;

                        case 2:
                            check = time;
                            break;
                    }

                    System.Threading.Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nGlad we cleared that up");
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\nWhat do you enjoy most about studying {currentStudy}?");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nWhat has been the biggest learning point in your studies so far?");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nWhat is the highlight of your study so far?");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                string highlight = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nWhat are your goals?");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\nWhat part of achieving {highlight} made it so memorable?");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nThank you very much, I'll now ask a few more questions if thats alright");
                Thread.Sleep(1000);

                
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nWhat is your highest qualification?");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                string highQal = Console.ReadLine();

                                
                Console.WriteLine("\nThank you very much, I'll now ask a few more questions if thats alright");
                Thread.Sleep(2000);
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\nDo you think getting your {highQal} prepared you for your studies in {currentStudy}?");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                string prepare = Console.ReadLine();
                ErrorCheck(prepare);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nDo you have any Learning Disabilities? (Y/N)");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                string learnDis = Console.ReadLine();
                learnDis = learnDis.ToLower();

                if (learnDis == "y")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nDid this impact your study? (Y/N)");                    
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"\nDo you have any help so you are able to do your best in {currentStudy}? (Y/N)");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.ReadLine();                  
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nDo you know anyone with a Learning Disability? (Y/N)");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.ReadLine();
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nThank you very much, I'll now ask a few more questions if thats alright");
                Thread.Sleep(2000);
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Do you have children? (Y/N)");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                string kids = Console.ReadLine();
                kids = kids.ToLower();

                if (kids == "y")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nDoes it have a large impact on your time management while studying? (Y/N) ");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.ReadLine();
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nThank you, I'll now ask a few more questions if thats alright");
                }

                string commitments = " ";

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nDo you have commitments outside of study? (Y/N)");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                commitments = Console.ReadLine();
                commitments = commitments.ToLower();

                string hobbies = " ";
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nDo you have any hobbies? (Y/N)");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                hobbies = Console.ReadLine();
                hobbies = hobbies.ToLower();

                if ((hobbies != "y") && (commitments == "y"))//Same here, your code wasn't running because you had used the OR(||), not the AND (&&) condition here
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nSorry I thought you said you didn't have any commitments. My mistake, I will update my records");
                    Thread.Sleep(1000);
                }

                else if ((hobbies == "y") && (commitments != "y"))//Same here, your code wasn't running because you had used the OR (||), not the AND (&&) condition here
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nSorry I thought you said you didn't have any commitments. My mistake, I will update my records");
                    Thread.Sleep(1000);
                }

                if ((hobbies == "y") && (commitments == "y"))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nWhat types of things do you do in your time outside of class?");
                    string activies = Console.ReadLine();
                    Thread.Sleep(1000);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"\nAre you able to balance your study with {activies}? (Y/N)");
                    string balance = Console.ReadLine();
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nThank you very much, you are 70% of the way through the questions");
                Thread.Sleep(1000);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nDid you have a gap between finishing high school and tertiary study? (Y/N)");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                string gapYear = Console.ReadLine();
                gapYear = gapYear.ToLower();

                if (gapYear == "y")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nDid you work?");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    string work = Console.ReadLine();
                    work = work.ToLower();
                    Thread.Sleep(1000);

                    if (work == "y")
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nDid that lead to your current Study? ");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nDid the Gap year benefit you? ");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Thread.Sleep(1000);
                    }
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nIf your were to go back would you take a gap year?");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.ReadLine();
                    Thread.Sleep(1000);
                }
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\nThank you very much, the answers to your questions are very helpful.\n");
                Thread.Sleep(1000);   
                Console.WriteLine("\nIf you would like to change any of your answers you may do so now as the program will run again\n");
                Thread.Sleep(1000);
                Console.WriteLine("\nAlternatively if you have a friend that would be willing to help, ask them to complete the questionaire as well\n");
                Thread.Sleep(1000);
                Console.WriteLine("\nDo you want to run it again (Y/N)\n");
                choice = Console.ReadLine().ToUpper();

                /*
                if (max - count == 3)
                {
                    max = max * 10;
                }
                (count < max)
                
                count++;
                */

            } while (choice != "N");

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
        }     
        
        public static void ErrorCheck(string prepare)
        {
            string positive_Words, unknown_Words, negative_Words, temp = prepare.ToUpper();
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

            string[] temp_Words = new string[temp.Length];

            temp_Words = temp.Replace(",", "").Split(' ');
            foreach (string yes in positive_Check)
            {
                foreach (string a in temp_Words)
                {
                    if (a == yes)
                    {
                        countP++;
                    }
                }
            }

            foreach (string maybe in unknown_Check)
            {
                foreach (string a in temp_Words)
                {
                    if (temp == maybe)
                    {
                        countU++;
                    }
                }
            }

            foreach (string no in negative_Check)
            {
                foreach (string a in temp_Words)
                {
                    if (temp == no)
                    {
                        countN++;
                    }
                }
            }

            //Console.WriteLine($"Do you think getting your {highQal} prepared you for your studies in {currentStudy}?");

            if (countP > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nThat's great to hear.");
            }

            if (countU > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("It sounds like you are not sure. It's okay, one day you will know whether it has paid off or not");
            }

            if (countN > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That's alright. All you can do now is work towards your current course");
            }            
        }
    }
}
