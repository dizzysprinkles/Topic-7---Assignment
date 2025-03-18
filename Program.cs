using System.Globalization;

namespace Topic_7___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            List<int> numbers = new List<int>();

            for (int i = 0; i < 25; i++)
                numbers.Add(generator.Next(10, 21));
                
            string choice = "";
            int numberChoice;
           
            int maxOccur;
            int popularNum;
            int secondPopNum;
            //int thirdPopNum;

            while (choice != "q")
            {
                Console.Clear();
                int occurences = 0;
                int average;
                Console.WriteLine("Welcome to Topic 7 Part 1's Main Menu! Please select an option to try based on the following list of integers: ");
                Console.WriteLine();
                for (int i = 0; i < numbers.Count; i++)
                    Console.Write(numbers[i] + ", ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Which part of this section would you like to try? ");
                Console.WriteLine("1 - Sort the list");
                Console.WriteLine("2 - Make a new list of random numbers");
                Console.WriteLine("3 - Remove a number (by value)");
                Console.WriteLine("4 - Add a number to the list");
                Console.WriteLine("5 - Count the number of occurences of a number");
                Console.WriteLine("6 - Print the largest value");
                Console.WriteLine("7 - Print the smallest value");
                Console.WriteLine("8 - Print the sum and the average of the list");
                Console.WriteLine("9 - Determine the most frequent number");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();
                if (choice == "q")
                {
                    Console.WriteLine("Thanks for playing! ");
                }
                else
                {
                    if (choice == "1") // Sort
                    {
                        Console.WriteLine("You've picked option 1 - Sort the list.");
                        Console.WriteLine("I will now sort the list! ");
                        numbers.Sort();
                        Console.WriteLine("Here is the new and improved sorted list!");
                        for (int i = 0; i < numbers.Count; i++)
                            Console.Write(numbers[i] + ", ");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Press ENTER to return to the Main Menu!");
                        Console.ReadLine();
                    }

                    else if (choice == "2") // New
                    {
                        Console.WriteLine("You've picked option 2 - Make a new list of random numbers.");
                        Console.WriteLine("I will now make a new list just for you! ");
                        numbers.Clear();
                        for (int i = 0; i < 25; i++)
                            numbers.Add(generator.Next(10, 21));
                        Console.WriteLine("Here is the new and improved list!");
                        for (int i = 0; i < numbers.Count; i++)
                            Console.Write(numbers[i] + ", ");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Press ENTER to return to the Main Menu!");
                        Console.ReadLine();
                    }
                    else if (choice == "3") // Remove
                    {
                        Console.WriteLine("You've picked option 3 - Remove a number");
                        Console.WriteLine("Which number would you like me to remove?  ");
                        while (!Int32.TryParse(Console.ReadLine(), out numberChoice))
                        {
                            Console.WriteLine("Invalid number. Try again!");
                        }
                        for (int i = 0; i < numbers.Count; i++)
                            numbers.Remove(numberChoice);

                        Console.WriteLine($"Here is the new and improved list without {numberChoice}!");
                        for (int i = 0; i < numbers.Count; i++)
                            Console.Write(numbers[i] + ", ");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Press ENTER to return to the Main Menu!");
                        Console.ReadLine();
                    }

                
                    else if (choice == "4") // Add #
                    {
                        Console.WriteLine("You've picked option 4 - Add a number to the list.");
                        Console.WriteLine("Which number would you like me to add?");
                        while (!Int32.TryParse(Console.ReadLine(), out numberChoice))
                        {
                            Console.WriteLine("Invalid number. Try again!");
                        }
                        numbers.Add(numberChoice);
                        Console.WriteLine($"Here's the list with the new number: {numberChoice}");
                        for (int i = 0; i < numbers.Count; i++)
                            Console.Write(numbers[i] + ", ");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Press ENTER to return to the Main Menu!");
                        Console.ReadLine();

                    }
                    else if (choice == "5") // # of Occurences
                    {
                        Console.WriteLine("You've picked option 5 - Count the number of occurences of a number ");
                        Console.WriteLine("Which number would you like me to count the occurences of?");
                        while (!Int32.TryParse(Console.ReadLine(), out numberChoice))
                        {
                            Console.WriteLine("Invalid number. Try again!");
                        }
                        for (int i = 0; i < numbers.Count; i++)
                            if (numbers[i].Equals(numberChoice))
                            {
                                occurences += 1;
                               
                            }
                        Console.WriteLine($"The number {numberChoice} occurs {occurences} times!");
                        Console.WriteLine();
                        Console.WriteLine("Press ENTER to return to the Main Menu!");
                        Console.ReadLine();

                    }
                    else if (choice == "6") // Largest
                    {
                        Console.WriteLine("You've picked option 6 - Print the largest value.");
                        Console.WriteLine("I will now tell you the largest value! ");
                        numbers.Sort();
                        Console.WriteLine($"The largest value is {numbers[numbers.Count - 1]}.");
                        Console.WriteLine();
                        Console.WriteLine("Press ENTER to return to the Main Menu!");
                        Console.ReadLine();
                    }
                    else if (choice == "7") // Smallest
                    {
                        Console.WriteLine("You've picked option 7 - Print the smallest value.");
                        Console.WriteLine("I will now tell you the smallest value! ");
                        numbers.Sort();
                        Console.WriteLine($"The smallest value is {numbers[0]}.");
                        Console.WriteLine();
                        Console.WriteLine("Press ENTER to return to the Main Menu!");
                        Console.ReadLine();

                    }
                    else if (choice == "8") // Sum and Average
                    {
                        Console.WriteLine("You've picked option 8 - Print the sum and average of the list.");
                        Console.WriteLine("I will now tell you the sum of the whole list! ");
                        Console.WriteLine($"The sum of all {numbers.Count} numbers is {numbers.Sum()}.");
                        average = numbers.Sum() / numbers.Count;
                        Console.WriteLine($"The average is about {average}.");
                        Console.WriteLine();
                        Console.WriteLine("Press ENTER to return to the Main Menu!");
                        Console.ReadLine();

                    }
                    else if (choice == "9") // Most frequent #
                    {
                        Console.WriteLine("You've picked option 9 - Determine the most frequent number ");
                        Console.WriteLine("");
                        occurences = 1;
                        maxOccur = 1;
                        numbers.Sort();
                        popularNum = 0;
                        secondPopNum = 0;
                        //thirdPopNum = 0;

                        for (int i = 1; i < numbers.Count; i++)
                        {
                            if (numbers[i] == numbers[i - 1])
                            {
                                occurences+=1;
                            }

                            else
                                occurences = 1;

                            if (occurences > maxOccur)
                            {
                                maxOccur = occurences;
                                popularNum = numbers[i];
                            }

                            if (occurences == maxOccur)
                            {
                                secondPopNum = numbers[i];
                            }

                        }

                        if (secondPopNum == popularNum)
                        {
                            Console.WriteLine($"The number {popularNum} occurs {maxOccur} times!");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine($"The number {popularNum} and the number {secondPopNum} both occur {maxOccur} times!");
                            Console.WriteLine();
                        }

                        Console.WriteLine("Press ENTER to return to the Main Menu!");
                        Console.ReadLine();

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
}
