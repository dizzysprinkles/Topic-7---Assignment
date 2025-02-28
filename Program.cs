namespace Topic_7___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";

            while (choice != "q")
            {
                Console.Clear(); 
                Console.WriteLine("Welcome to Topic 7's Main Menu!  Please select an option to try:");
                Console.WriteLine();
                Console.WriteLine("1 - List of Integers");
                Console.WriteLine("2 - List of Strings");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1")
                {
                    Console.WriteLine("You chose option 1 - List of Integers");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }

                else if (choice == "2")
                {
                    Console.WriteLine("You chose option 2 - List of Strings");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }

                else if (choice == "q")
                {
                    Console.WriteLine("Thanks for playing!");
                    return;
                }

                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
            }
        }
    }
}
