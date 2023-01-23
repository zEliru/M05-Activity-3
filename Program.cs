using System.Linq.Expressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyFromUser;
            do
            {
                ShowMenu();
                keyFromUser = Console.ReadKey();
                switch (keyFromUser.Key)
                {
                    case ConsoleKey.D1:
                        // topic 1
                        break;
                    case ConsoleKey.D2:
                        // topic 2
                        break;
                    case ConsoleKey.D3:
                        // topic 3
                        break;
                    case ConsoleKey.D4:
                        TopicFourQuestions();
                        break;
                    case ConsoleKey.D5:
                        TopicFiveQuestions();
                        break;
                    case ConsoleKey.D6:
                        TopicSixQuestions();
                        break;
                    case ConsoleKey.D0:
                        // topic 6
                        break;
                    default:
                        Console.WriteLine("Error: You pressed an invalid button.");
                        break;
                }
            } while (keyFromUser.Key != ConsoleKey.D0);

        }
        public static void ShowMenu() {
            Console.Clear();
            Console.WriteLine("Welcome to the main menu");
            Console.WriteLine("1 - Topic 1");
            Console.WriteLine("2 - Topic 2");
            Console.WriteLine("3 - Topic 3");
            Console.WriteLine("4 - Topic 4");
            Console.WriteLine("5 - Topic 5");
            Console.WriteLine("6 - Topic 6");
            Console.WriteLine("0 - Exit");


        }

        //Edu


        //Oleg
        public static void TopicFourQuestions()
        {
            int choosenNumber = 0;
            bool valid = false;
            Console.WriteLine("WELCOME TO TOPIC #4 - ????");
            while (!valid)
            {
                try
                {
                    Console.WriteLine("1st Question - ????");
                    Console.WriteLine("Option 1 - ????");
                    Console.WriteLine("Option 2 - ????");
                    Console.WriteLine("Option 3 - ????");
                    Console.WriteLine("Option 4 - ????");
                    choosenNumber = Convert.ToInt32(Console.ReadLine());

                    switch (choosenNumber)
                    {
                        case 1:
                            valid = true;
                            break;
                        case 2:
                            valid = true;
                            break;
                        case 3:
                            valid = true;
                            break;
                        case 4:
                            valid = true;
                            break;
                        default:
                            throw 
                                new Exception("ERROR - ENTER A NUMBER BETWEEN 1 - 4");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } // TOPIC 4 - Q1
            valid = false;
            Console.WriteLine("SUBMITTED ANSWER TO OUR DATEBASE");
            while (!valid)
            {
                try
                {
                    Console.WriteLine("2nd Question - ????");
                    Console.WriteLine("Option 1 - ????");
                    Console.WriteLine("Option 2 - ????");
                    Console.WriteLine("Option 3 - ????");
                    Console.WriteLine("Option 4 - ????");
                    choosenNumber = Convert.ToInt32(Console.ReadLine());

                    switch (choosenNumber)
                    {
                        case 1:
                            valid = true;
                            break;
                        case 2:
                            valid = true;
                            break;
                        case 3:
                            valid = true;
                            break;
                        case 4:
                            valid = true;
                            break;
                        default:
                            throw
                                new Exception("ERROR - ENTER A NUMBER BETWEEN 1 - 4");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } // TOPIC 4 - Q2
            valid = false;
            Console.WriteLine("SUBMITTED ANSWER TO OUR DATEBASE");
            while (!valid)
            {
                try
                {
                    Console.WriteLine("3rd Question - ????");
                    Console.WriteLine("Option 1 - ????");
                    Console.WriteLine("Option 2 - ????");
                    Console.WriteLine("Option 3 - ????");
                    Console.WriteLine("Option 4 - ????");
                    choosenNumber = Convert.ToInt32(Console.ReadLine());

                    switch (choosenNumber)
                    {
                        case 1:
                            valid = true;
                            break;
                        case 2:
                            valid = true;
                            break;
                        case 3:
                            valid = true;
                            break;
                        case 4:
                            valid = true;
                            break;
                        default:
                            throw
                                new Exception("ERROR - ENTER A NUMBER BETWEEN 1 - 4");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } // TOPIC 4 - Q3
            valid = false;
            Console.WriteLine("SUBMITTED ANSWER TO OUR DATEBASE");
            while (!valid)
            {
                try
                {
                    Console.WriteLine("3rd Question - ????");
                    Console.WriteLine("Option 1 - ????");
                    Console.WriteLine("Option 2 - ????");
                    Console.WriteLine("Option 3 - ????");
                    Console.WriteLine("Option 4 - ????");
                    choosenNumber = Convert.ToInt32(Console.ReadLine());

                    switch (choosenNumber)
                    {
                        case 1:
                            valid = true;
                            break;
                        case 2:
                            valid = true;
                            break;
                        case 3:
                            valid = true;
                            break;
                        case 4:
                            valid = true;
                            break;
                        default:
                            throw
                                new Exception("ERROR - ENTER A NUMBER BETWEEN 1 - 4");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } // TOPIC 4 - Q4
            valid = false;
            Console.WriteLine("SUBMITTED ANSWER TO OUR DATEBASE");
            ShowMenu();
        }

        public static void TopicFiveQuestions()
        {
            int choosenNumber = 0;
            bool valid = false;
            Console.WriteLine("WELCOME TO TOPIC #4 - ????");
            while (!valid)
            {
                try
                {
                    Console.WriteLine("1st Question - ????");
                    Console.WriteLine("Option 1 - ????");
                    Console.WriteLine("Option 2 - ????");
                    Console.WriteLine("Option 3 - ????");
                    Console.WriteLine("Option 4 - ????");
                    choosenNumber = Convert.ToInt32(Console.ReadLine());

                    switch (choosenNumber)
                    {
                        case 1:
                            valid = true;
                            break;
                        case 2:
                            valid = true;
                            break;
                        case 3:
                            valid = true;
                            break;
                        case 4:
                            valid = true;
                            break;
                        default:
                            throw
                                new Exception("ERROR - ENTER A NUMBER BETWEEN 1 - 4");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } // TOPIC 5 - Q1
            valid = false;
            Console.WriteLine("SUBMITTED ANSWER TO OUR DATEBASE");
            while (!valid)
            {
                try
                {
                    Console.WriteLine("2nd Question - ????");
                    Console.WriteLine("Option 1 - ????");
                    Console.WriteLine("Option 2 - ????");
                    Console.WriteLine("Option 3 - ????");
                    Console.WriteLine("Option 4 - ????");
                    choosenNumber = Convert.ToInt32(Console.ReadLine());

                    switch (choosenNumber)
                    {
                        case 1:
                            valid = true;
                            break;
                        case 2:
                            valid = true;
                            break;
                        case 3:
                            valid = true;
                            break;
                        case 4:
                            valid = true;
                            break;
                        default:
                            throw
                                new Exception("ERROR - ENTER A NUMBER BETWEEN 1 - 4");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } // TOPIC 5 - Q2
            valid = false;
            Console.WriteLine("SUBMITTED ANSWER TO OUR DATEBASE");
            while (!valid)
            {
                try
                {
                    Console.WriteLine("3rd Question - ????");
                    Console.WriteLine("Option 1 - ????");
                    Console.WriteLine("Option 2 - ????");
                    Console.WriteLine("Option 3 - ????");
                    Console.WriteLine("Option 4 - ????");
                    choosenNumber = Convert.ToInt32(Console.ReadLine());

                    switch (choosenNumber)
                    {
                        case 1:
                            valid = true;
                            break;
                        case 2:
                            valid = true;
                            break;
                        case 3:
                            valid = true;
                            break;
                        case 4:
                            valid = true;
                            break;
                        default:
                            throw
                                new Exception("ERROR - ENTER A NUMBER BETWEEN 1 - 4");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } // TOPIC 5 - Q3
            valid = false;
            Console.WriteLine("SUBMITTED ANSWER TO OUR DATEBASE");
            while (!valid)
            {
                try
                {
                    Console.WriteLine("3rd Question - ????");
                    Console.WriteLine("Option 1 - ????");
                    Console.WriteLine("Option 2 - ????");
                    Console.WriteLine("Option 3 - ????");
                    Console.WriteLine("Option 4 - ????");
                    choosenNumber = Convert.ToInt32(Console.ReadLine());

                    switch (choosenNumber)
                    {
                        case 1:
                            valid = true;
                            break;
                        case 2:
                            valid = true;
                            break;
                        case 3:
                            valid = true;
                            break;
                        case 4:
                            valid = true;
                            break;
                        default:
                            throw
                                new Exception("ERROR - ENTER A NUMBER BETWEEN 1 - 4");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } // TOPIC 5 - Q4
            valid = false;
            Console.WriteLine("SUBMITTED ANSWER TO OUR DATEBASE");
            ShowMenu();
        }

        public static void TopicSixQuestions()
        {
            int choosenNumber = 0;
            bool valid = false;
            Console.WriteLine("WELCOME TO TOPIC #4 - ????");
            while (!valid)
            {
                try
                {
                    Console.WriteLine("1st Question - ????");
                    Console.WriteLine("Option 1 - ????");
                    Console.WriteLine("Option 2 - ????");
                    Console.WriteLine("Option 3 - ????");
                    Console.WriteLine("Option 4 - ????");
                    choosenNumber = Convert.ToInt32(Console.ReadLine());

                    switch (choosenNumber)
                    {
                        case 1:
                            valid = true;
                            break;
                        case 2:
                            valid = true;
                            break;
                        case 3:
                            valid = true;
                            break;
                        case 4:
                            valid = true;
                            break;
                        default:
                            throw
                                new Exception("ERROR - ENTER A NUMBER BETWEEN 1 - 4");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } // TOPIC 6 - Q1
            valid = false;
            Console.WriteLine("SUBMITTED ANSWER TO OUR DATEBASE");
            while (!valid)
            {
                try
                {
                    Console.WriteLine("2nd Question - ????");
                    Console.WriteLine("Option 1 - ????");
                    Console.WriteLine("Option 2 - ????");
                    Console.WriteLine("Option 3 - ????");
                    Console.WriteLine("Option 4 - ????");
                    choosenNumber = Convert.ToInt32(Console.ReadLine());

                    switch (choosenNumber)
                    {
                        case 1:
                            valid = true;
                            break;
                        case 2:
                            valid = true;
                            break;
                        case 3:
                            valid = true;
                            break;
                        case 4:
                            valid = true;
                            break;
                        default:
                            throw
                                new Exception("ERROR - ENTER A NUMBER BETWEEN 1 - 4");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } // TOPIC 6 - Q2
            valid = false;
            Console.WriteLine("SUBMITTED ANSWER TO OUR DATEBASE");
            while (!valid)
            {
                try
                {
                    Console.WriteLine("3rd Question - ????");
                    Console.WriteLine("Option 1 - ????");
                    Console.WriteLine("Option 2 - ????");
                    Console.WriteLine("Option 3 - ????");
                    Console.WriteLine("Option 4 - ????");
                    choosenNumber = Convert.ToInt32(Console.ReadLine());

                    switch (choosenNumber)
                    {
                        case 1:
                            valid = true;
                            break;
                        case 2:
                            valid = true;
                            break;
                        case 3:
                            valid = true;
                            break;
                        case 4:
                            valid = true;
                            break;
                        default:
                            throw
                                new Exception("ERROR - ENTER A NUMBER BETWEEN 1 - 4");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } // TOPIC 6 - Q3
            valid = false;
            Console.WriteLine("SUBMITTED ANSWER TO OUR DATEBASE");
            while (!valid)
            {
                try
                {
                    Console.WriteLine("3rd Question - ????");
                    Console.WriteLine("Option 1 - ????");
                    Console.WriteLine("Option 2 - ????");
                    Console.WriteLine("Option 3 - ????");
                    Console.WriteLine("Option 4 - ????");
                    choosenNumber = Convert.ToInt32(Console.ReadLine());

                    switch (choosenNumber)
                    {
                        case 1:
                            valid = true;
                            break;
                        case 2:
                            valid = true;
                            break;
                        case 3:
                            valid = true;
                            break;
                        case 4:
                            valid = true;
                            break;
                        default:
                            throw
                                new Exception("ERROR - ENTER A NUMBER BETWEEN 1 - 4");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } // TOPIC 6 - Q4
            valid = false;
            Console.WriteLine("SUBMITTED ANSWER TO OUR DATEBASE");
            ShowMenu();
        }

        //end
    }
}