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
            Console.WriteLine("1 - Colors");
            Console.WriteLine("2 - Food");
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
            Console.WriteLine("Hi, welcome to topic one: Colors.");
            bool valid = false;
            while (!valid)
            {
                try
                {
                    int choiceFromUser = 0;                    
                    Console.WriteLine("Question 1: What's my favorite color?");
                    Console.WriteLine("1 - Red");
                    Console.WriteLine("2 - Green");
                    Console.WriteLine("3 - Blue");
                    Console.WriteLine("4 - Edu");
                    choiceFromUser = Convert.ToInt32(Console.ReadLine());
                    switch (choiceFromUser)
                    {
                        case 1:
                            Console.WriteLine("Wrong.");
                            valid = true;
                            break;
                        case 2:
                            Console.WriteLine("Wrong");
                            valid = true;
                            break;
                        case 3:
                            Console.WriteLine("Wrong");
                            valid = true;
                            break;
                        case 4:
                            Console.WriteLine("Correct.");
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
            Console.WriteLine("Answer properly processed.");
            while (!valid)
            {
                try
                {
                    int choiceFromUser = 0;
                    Console.WriteLine("Question 2: What's YOUR favorite color?");
                    Console.WriteLine("1 - Edu");
                    Console.WriteLine("2 - Edu");
                    Console.WriteLine("3 - Not Edu");
                    Console.WriteLine("4 - Edu");
                    choiceFromUser = Convert.ToInt32(Console.ReadLine());
                    switch (choiceFromUser)
                    {
                        case 1:
                            Console.WriteLine("Wrong");
                            valid = true;
                            break;
                        case 2:
                            Console.WriteLine("Wrong");
                            valid = true;
                            break;
                        case 3:
                            Console.WriteLine("Correct");
                            valid = true;
                            break;
                        case 4:
                            Console.WriteLine("Wrong");
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
            Console.WriteLine("Answer properly processed.");
            while (!valid)
            {
                try
                {
                    int choiceFromUser = 0;
                    Console.WriteLine("Question 3: What color fits me best?");
                    Console.WriteLine("1 - Black");
                    Console.WriteLine("2 - White");
                    Console.WriteLine("3 - Yellow");
                    Console.WriteLine("4 - Purple");
                    choiceFromUser = Convert.ToInt32(Console.ReadLine());
                    switch (choiceFromUser)
                    {
                        case 1:
                            Console.WriteLine("Correct");
                            valid = true;
                            break;
                        case 2:
                            Console.WriteLine("Wrong");
                            valid = true;
                            break;
                        case 3:
                            Console.WriteLine("Wrong");
                            valid = true;
                            break;
                        case 4:
                            Console.WriteLine("Wrong");
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
            Console.WriteLine("Answer properly processed.");
            while (!valid)
            {
                try
                {
                    int choiceFromUser = 0;
                    Console.WriteLine("Question 4: When blod dries up, what color does it take?");
                    Console.WriteLine("1 - Brown");
                    Console.WriteLine("2 - Green");
                    Console.WriteLine("3 - It stays red you idiot");
                    Console.WriteLine("4 - Does it even have a color");
                    choiceFromUser = Convert.ToInt32(Console.ReadLine());
                    switch (choiceFromUser)
                    {
                        case 1:
                            Console.WriteLine("Correct, how did you know though");
                            valid = true;
                            break;
                        case 2:
                            Console.WriteLine("Wrong");
                            valid = true;
                            break;
                        case 3:
                            Console.WriteLine("Wrong and please don't insult me anymore I have FEELINGS :(");
                            valid = true;
                            break;
                        case 4:
                            Console.WriteLine("Yes... obviously... anyways, wrong answer");
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
            Console.WriteLine("Answer properly processed.");
            while (!valid)
            {
                try
                {
                    int choiceFromUser = 0;
                    Console.WriteLine("Question 5: What are colors made of?");
                    Console.WriteLine("1 - Colors");
                    Console.WriteLine("2 - It's all about the light and how it hits objects");
                    Console.WriteLine("3 - Pencils");
                    Console.WriteLine("4 - To be or not to be");
                    choiceFromUser = Convert.ToInt32(Console.ReadLine());
                    switch (choiceFromUser)
                    {
                        case 1:
                            Console.WriteLine("Wrong");
                            valid = true;
                            break;
                        case 2:
                            Console.WriteLine("Wrong");
                            valid = true;
                            break;
                        case 3:
                            Console.WriteLine("Wrong");
                            valid = true;
                            break;
                        case 4:
                            Console.WriteLine("That is, indeed, the question");
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
            Console.WriteLine("Thank you for participating. Press any key to go to the menu.");
            Console.ReadKey();

            ShowMenu();


        }
        public static void TopicTwoQuestions()
        {
            Console.Clear();
            Console.WriteLine("Hi, welcome to topic two: food.");
            bool valid = false;
            while (!valid)
            {
                try
                {
                    int choiceFromUser = 0;
                    Console.WriteLine("Question 1: What's my favorite food?");
                    Console.WriteLine("1 - Ramen");
                    Console.WriteLine("2 - Yakisoba");
                    Console.WriteLine("3 - Truita de patates amb ceba, godlike");
                    Console.WriteLine("4 - Fish");
                    choiceFromUser = Convert.ToInt32(Console.ReadLine());
                    switch (choiceFromUser)
                    {
                        case 1:
                            Console.WriteLine("YEP");
                            valid = true;
                            break;
                        case 2:
                            Console.WriteLine("YEP");
                            valid = true;
                            break;
                        case 3:
                            Console.WriteLine("YEP");
                            valid = true;
                            break;
                        case 4:
                            Console.WriteLine("Ewww no that's disgusting");
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
                    Console.WriteLine("Question 2: What's the best ingredient for absolutely everything?");
                    Console.WriteLine("1 - Potatoes");
                    Console.WriteLine("2 - M03 - Programació");
                    Console.WriteLine("3 - Chicken");
                    Console.WriteLine("4 - Cereals");
                    choiceFromUser = Convert.ToInt32(Console.ReadLine());
                    switch (choiceFromUser)
                    {
                        case 1:
                            Console.WriteLine("YEPYEPYEPYEPYEPYEP");
                            valid = true;
                            break;
                        case 2:
                            Console.WriteLine("Even though I love it, sadly, it's not food. Wrong answer. ");
                            valid = true;
                            break;
                        case 3:
                            Console.WriteLine("Definitely not better than potatoes, sorry. Wrong.");
                            valid = true;
                            break;
                        case 4:
                            Console.WriteLine("NOT REALLY BUT CEREALS ARE VERY GOOD I KNOW");
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
                    Console.WriteLine("Question 3: What do rabbits eat (hint: it's orange)");
                    Console.WriteLine("1 - Orange");
                    Console.WriteLine("2 - Oranges");
                    Console.WriteLine("3 - Carrot");
                    Console.WriteLine("4 - Rotten carrots");
                    choiceFromUser = Convert.ToInt32(Console.ReadLine());
                    switch (choiceFromUser)
                    {
                        case 1:
                            Console.WriteLine("You fell for it hehe. Wrong.");
                            valid = true;
                            break;
                        case 2:
                            Console.WriteLine("Nope");
                            valid = true;
                            break;
                        case 3:
                            Console.WriteLine("Correct");
                            valid = true;
                            break;
                        case 4:
                            Console.WriteLine("Poor rabbits... wrong");
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
                    Console.WriteLine("Question 4: What's my favorite color?");
                    Console.WriteLine("1 - Wait that's not food");
                    Console.WriteLine("2 - Green");
                    Console.WriteLine("3 - CAN WE PLEASE TALK ABOUT FOOD");
                    Console.WriteLine("4 - Cereals");
                    choiceFromUser = Convert.ToInt32(Console.ReadLine());
                    switch (choiceFromUser)
                    {
                        case 1:
                            Console.WriteLine("YEP, wrong answer");
                            valid = true;
                            break;
                        case 2:
                            Console.WriteLine("Wrong, not food.");
                            valid = true;
                            break;
                        case 3:
                            Console.WriteLine("NO");
                            valid = true;
                            break;
                        case 4:
                            Console.WriteLine("Correct");
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
                    Console.WriteLine("Question 3: What makes you cry when cut?");
                    Console.WriteLine("1 - Onions ");
                    Console.WriteLine("2 - Isn't this question number 5...");
                    Console.WriteLine("3 - Girlfriend");
                    Console.WriteLine("4 - Rice");
                    choiceFromUser = Convert.ToInt32(Console.ReadLine());
                    switch (choiceFromUser)
                    {
                        case 1:
                            Console.WriteLine("Correct.");
                            valid = true;
                            break;
                        case 2:
                            Console.WriteLine("Indeed. But wrong answer.");
                            valid = true;
                            break;
                        case 3:
                            Console.WriteLine("Girlfriends shouldn't be cut. Wrong answer though");
                            valid = true;
                            break;
                        case 4:
                            Console.WriteLine("Why would anyone ever cut rice.... Wrong answer");
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
            Console.WriteLine("Thank you for participating. Press any key to go to the menu.");
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