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
                        TopicOneQuestions();
                        break;
                    case ConsoleKey.D2:
                        TopicTwoQuestions();
                        break;
                    case ConsoleKey.D3:
                        TopicThreeQuestions();
                        break;
                    case ConsoleKey.D4:
                        // topic 4
                        break;
                    case ConsoleKey.D5:
                        // topic 5
                        break;
                    case ConsoleKey.D6:
                        // topic 6
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

        public static void TopicOneQuestions()
        {
            Console.Clear();
            Console.WriteLine("Hi, welcome to Topic One XD.");
            bool valid = false;
            while (!valid)
            {
                try
                {
                    int choiceFromUser = 0;                    
                    Console.WriteLine("Question 1: What's my favorite color?");
                    Console.WriteLine("1 - ");
                    Console.WriteLine("2 - ");
                    Console.WriteLine("3 - ");
                    Console.WriteLine("4 - ");
                    choiceFromUser = Convert.ToInt32(Console.ReadLine());
                    switch (choiceFromUser)
                    {
                        case 1:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 2:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 3:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 4:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        default:
                            Console.WriteLine("Error");
                            throw new Exception("Numbers between 1 and 4, please and thank you");
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            }
            valid = false;
            Console.WriteLine("Answer submitted.");
            while (!valid)
            {
                try
                {
                    int choiceFromUser = 0;
                    Console.WriteLine("Question 1: What's my favorite color?");
                    Console.WriteLine("1 - ");
                    Console.WriteLine("2 - ");
                    Console.WriteLine("3 - ");
                    Console.WriteLine("4 - ");
                    choiceFromUser = Convert.ToInt32(Console.ReadLine());
                    switch (choiceFromUser)
                    {
                        case 1:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 2:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 3:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 4:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        default:
                            Console.WriteLine("Error");
                            throw new Exception("Numbers between 1 and 4, please and thank you");
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            }
            valid = false;
            Console.WriteLine("Answer submitted.");
            while (!valid)
            {
                try
                {
                    int choiceFromUser = 0;
                    Console.WriteLine("Question 1: What's my favorite color?");
                    Console.WriteLine("1 - ");
                    Console.WriteLine("2 - ");
                    Console.WriteLine("3 - ");
                    Console.WriteLine("4 - ");
                    choiceFromUser = Convert.ToInt32(Console.ReadLine());
                    switch (choiceFromUser)
                    {
                        case 1:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 2:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 3:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 4:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        default:
                            Console.WriteLine("Error");
                            throw new Exception("Numbers between 1 and 4, please and thank you");
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            }
            valid = false;
            Console.WriteLine("Answer submitted.");
            while (!valid)
            {
                try
                {
                    int choiceFromUser = 0;
                    Console.WriteLine("Question 1: What's my favorite color?");
                    Console.WriteLine("1 - ");
                    Console.WriteLine("2 - ");
                    Console.WriteLine("3 - ");
                    Console.WriteLine("4 - ");
                    choiceFromUser = Convert.ToInt32(Console.ReadLine());
                    switch (choiceFromUser)
                    {
                        case 1:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 2:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 3:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 4:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        default:
                            Console.WriteLine("Error");
                            throw new Exception("Numbers between 1 and 4, please and thank you");
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            }
            valid = false;
            Console.WriteLine("Answer submitted.");
            while (!valid)
            {
                try
                {
                    int choiceFromUser = 0;
                    Console.WriteLine("Question 1: What's my favorite color?");
                    Console.WriteLine("1 - ");
                    Console.WriteLine("2 - ");
                    Console.WriteLine("3 - ");
                    Console.WriteLine("4 - ");
                    choiceFromUser = Convert.ToInt32(Console.ReadLine());
                    switch (choiceFromUser)
                    {
                        case 1:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 2:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 3:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 4:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        default:
                            Console.WriteLine("Error");
                            throw new Exception("Numbers between 1 and 4, please and thank you");
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            }
            valid = false;
            Console.WriteLine("Answer submitted.");

            ShowMenu();


        }
        public static void TopicTwoQuestions()
        {
            Console.Clear();
            Console.WriteLine("Hi, welcome to Topic One XD.");
            bool valid = false;
            while (!valid)
            {
                try
                {
                    int choiceFromUser = 0;
                    Console.WriteLine("Question 1: What's my favorite color?");
                    Console.WriteLine("1 - ");
                    Console.WriteLine("2 - ");
                    Console.WriteLine("3 - ");
                    Console.WriteLine("4 - ");
                    choiceFromUser = Convert.ToInt32(Console.ReadLine());
                    switch (choiceFromUser)
                    {
                        case 1:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 2:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 3:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 4:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        default:
                            Console.WriteLine("Error");
                            throw new Exception("Numbers between 1 and 4, please and thank you");
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            }
            valid = false;

            while (!valid)
            {
                try
                {
                    int choiceFromUser = 0;
                    Console.WriteLine("Question 1: What's my favorite color?");
                    Console.WriteLine("1 - ");
                    Console.WriteLine("2 - ");
                    Console.WriteLine("3 - ");
                    Console.WriteLine("4 - ");
                    choiceFromUser = Convert.ToInt32(Console.ReadLine());
                    switch (choiceFromUser)
                    {
                        case 1:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 2:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 3:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 4:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        default:
                            Console.WriteLine("Error");
                            throw new Exception("Numbers between 1 and 4, please and thank you");
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            }
            valid = false;
            Console.WriteLine("Answer submitted.");
            while (!valid)
            {
                try
                {
                    int choiceFromUser = 0;
                    Console.WriteLine("Question 1: What's my favorite color?");
                    Console.WriteLine("1 - ");
                    Console.WriteLine("2 - ");
                    Console.WriteLine("3 - ");
                    Console.WriteLine("4 - ");
                    choiceFromUser = Convert.ToInt32(Console.ReadLine());
                    switch (choiceFromUser)
                    {
                        case 1:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 2:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 3:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 4:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        default:
                            Console.WriteLine("Error");
                            throw new Exception("Numbers between 1 and 4, please and thank you");
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            }
            valid = false;
            Console.WriteLine("Answer submitted.");
            while (!valid)
            {
                try
                {
                    int choiceFromUser = 0;
                    Console.WriteLine("Question 1: What's my favorite color?");
                    Console.WriteLine("1 - ");
                    Console.WriteLine("2 - ");
                    Console.WriteLine("3 - ");
                    Console.WriteLine("4 - ");
                    choiceFromUser = Convert.ToInt32(Console.ReadLine());
                    switch (choiceFromUser)
                    {
                        case 1:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 2:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 3:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 4:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        default:
                            Console.WriteLine("Error");
                            throw new Exception("Numbers between 1 and 4, please and thank you");
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            }
            valid = false;
            Console.WriteLine("Answer submitted.");
            while (!valid)
            {
                try
                {
                    int choiceFromUser = 0;
                    Console.WriteLine("Question 1: What's my favorite color?");
                    Console.WriteLine("1 - ");
                    Console.WriteLine("2 - ");
                    Console.WriteLine("3 - ");
                    Console.WriteLine("4 - ");
                    choiceFromUser = Convert.ToInt32(Console.ReadLine());
                    switch (choiceFromUser)
                    {
                        case 1:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 2:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 3:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 4:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        default:
                            Console.WriteLine("Error");
                            throw new Exception("Numbers between 1 and 4, please and thank you");
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            }
            valid = false;
            Console.WriteLine("Answer submitted.");
            ShowMenu();



        }
        public static void TopicThreeQuestions()
        {
            Console.Clear();
            Console.WriteLine("Hi, welcome to Topic One XD.");
            bool valid = false;
            while (!valid)
            {
                try
                {
                    int choiceFromUser = 0;
                    Console.WriteLine("Question 1: What's my favorite color?");
                    Console.WriteLine("1 - ");
                    Console.WriteLine("2 - ");
                    Console.WriteLine("3 - ");
                    Console.WriteLine("4 - ");
                    choiceFromUser = Convert.ToInt32(Console.ReadLine());
                    switch (choiceFromUser)
                    {
                        case 1:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 2:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 3:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 4:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        default:
                            Console.WriteLine("Error");
                            throw new Exception("Numbers between 1 and 4, please and thank you");
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            }
            valid = false;
            Console.WriteLine("Answer submitted.");
            while (!valid)
            {
                try
                {
                    int choiceFromUser = 0;
                    Console.WriteLine("Question 1: What's my favorite color?");
                    Console.WriteLine("1 - ");
                    Console.WriteLine("2 - ");
                    Console.WriteLine("3 - ");
                    Console.WriteLine("4 - ");
                    choiceFromUser = Convert.ToInt32(Console.ReadLine());
                    switch (choiceFromUser)
                    {
                        case 1:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 2:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 3:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 4:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        default:
                            Console.WriteLine("Error");
                            throw new Exception("Numbers between 1 and 4, please and thank you");
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            }
            valid = false;
            Console.WriteLine("Answer submitted.");
            while (!valid)
            {
                try
                {
                    int choiceFromUser = 0;
                    Console.WriteLine("Question 1: What's my favorite color?");
                    Console.WriteLine("1 - ");
                    Console.WriteLine("2 - ");
                    Console.WriteLine("3 - ");
                    Console.WriteLine("4 - ");
                    choiceFromUser = Convert.ToInt32(Console.ReadLine());
                    switch (choiceFromUser)
                    {
                        case 1:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 2:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 3:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 4:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        default:
                            Console.WriteLine("Error");
                            throw new Exception("Numbers between 1 and 4, please and thank you");
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            }
            valid = false;
            Console.WriteLine("Answer submitted.");
            while (!valid)
            {
                try
                {
                    int choiceFromUser = 0;
                    Console.WriteLine("Question 1: What's my favorite color?");
                    Console.WriteLine("1 - ");
                    Console.WriteLine("2 - ");
                    Console.WriteLine("3 - ");
                    Console.WriteLine("4 - ");
                    choiceFromUser = Convert.ToInt32(Console.ReadLine());
                    switch (choiceFromUser)
                    {
                        case 1:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 2:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 3:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 4:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        default:
                            Console.WriteLine("Error");
                            throw new Exception("Numbers between 1 and 4, please and thank you");
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            }
            valid = false;
            Console.WriteLine("Answer submitted.");
            while (!valid)
            {
                try
                {
                    int choiceFromUser = 0;
                    Console.WriteLine("Question 1: What's my favorite color?");
                    Console.WriteLine("1 - ");
                    Console.WriteLine("2 - ");
                    Console.WriteLine("3 - ");
                    Console.WriteLine("4 - ");
                    choiceFromUser = Convert.ToInt32(Console.ReadLine());
                    switch (choiceFromUser)
                    {
                        case 1:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 2:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 3:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        case 4:
                            Console.WriteLine("");
                            valid = true;
                            break;
                        default:
                            Console.WriteLine("Error");
                            throw new Exception("Numbers between 1 and 4, please and thank you");
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            }
            valid = false;
            Console.WriteLine("Answer submitted.");

            ShowMenu();


        }








        //Oleg


        //end
    }
}