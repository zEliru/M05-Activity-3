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


        //Oleg


        //end
    }
}