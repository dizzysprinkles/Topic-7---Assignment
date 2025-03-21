using System.Globalization;
using System.Collections.Generic;

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
            int numberChoice, maxOccur, occurences, average;

            List<int> mostPopularNum = new List<int>();

            while (choice != "q")
            {
                Console.Clear();
                occurences = 0;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Welcome to Topic 7 Part 1's Main Menu! Please select an option to try based on the following list of integers: ");
                Console.WriteLine();
                Console.ForegroundColor= ConsoleColor.DarkYellow;
                Console.Write(String.Join(", ", numbers));
                Console.ForegroundColor = ConsoleColor.DarkCyan;
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
                Console.ForegroundColor= ConsoleColor.White;
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();
                if (choice == "q")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Thanks for playing! ");
                }
                else
                {
                    if (choice == "1") 
                    {
                        Console.WriteLine("You've picked option 1 - Sort the list.");
                        Console.WriteLine("I will now sort the list! ");
                        numbers.Sort();
                        Console.WriteLine();
                        Console.WriteLine("Here is the new and improved sorted list!");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(String.Join(", ", numbers));
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Press ENTER to return to the Main Menu!");
                        Console.ReadLine();
                    }
                    else if (choice == "2") 
                    {
                        Console.WriteLine("You've picked option 2 - Make a new list of random numbers.");
                        Console.WriteLine("I will now make a new list just for you! ");
                        numbers.Clear();
                        Console.WriteLine();
                        for (int i = 0; i < 25; i++)
                            numbers.Add(generator.Next(10, 21));
                        Console.WriteLine("Here is the new and improved list!");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(String.Join(", ", numbers));
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Press ENTER to return to the Main Menu!");
                        Console.ReadLine();
                    }
                    else if (choice == "3")
                    {
                        Console.WriteLine("You've picked option 3 - Remove a number");
                        Console.WriteLine("Which number would you like me to remove?  ");
                        Console.WriteLine();
                        while (!Int32.TryParse(Console.ReadLine(), out numberChoice))
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Invalid number. Try again!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (numbers.Contains(numberChoice))
                        {
                            for (int i = 0; i < numbers.Count; i++)
                                numbers.Remove(numberChoice);
                            Console.WriteLine();
                            Console.WriteLine($"Here is the new and improved list without {numberChoice}!");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine();
                            Console.Write(String.Join(", ", numbers));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine($"The list does not contain {numberChoice}, therefore it was not removed.");
                            Console.WriteLine();
                        }

                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Press ENTER to return to the Main Menu!");
                        Console.ReadLine();
                    }
                    else if (choice == "4")
                    {
                        Console.WriteLine("You've picked option 4 - Add a number to the list.");
                        Console.WriteLine("Which number would you like me to add?");
                        Console.WriteLine();
                        while (!Int32.TryParse(Console.ReadLine(), out numberChoice))
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Invalid number. Try again!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        numbers.Add(numberChoice);
                        Console.WriteLine();
                        Console.WriteLine($"Here's the list with the new number: {numberChoice}");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(String.Join(", ", numbers));
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Press ENTER to return to the Main Menu!");
                        Console.ReadLine();

                    }
                    else if (choice == "5")
                    {
                        Console.WriteLine("You've picked option 5 - Count the number of occurences of a number ");
                        Console.WriteLine("Which number would you like me to count the occurences of?");
                        Console.WriteLine();
                        while (!Int32.TryParse(Console.ReadLine(), out numberChoice))
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Invalid number. Try again!");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (numbers.Contains(numberChoice))
                        {
                            for (int i = 0; i < numbers.Count; i++)
                                if (numbers[i].Equals(numberChoice))
                                {
                                    occurences += 1;

                                }
                            Console.WriteLine();
                            Console.WriteLine($"The number {numberChoice} occurs {occurences} times!");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Sorry but the list does not contain {numberChoice}. It occurs 0 times.");
                            Console.WriteLine();
                        }
                   
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Press ENTER to return to the Main Menu!");
                        Console.ReadLine();

                    }
                    else if (choice == "6")
                    {
                        Console.WriteLine("You've picked option 6 - Print the largest value.");
                        Console.WriteLine("I will now tell you the largest value! ");
                        numbers.Sort();
                        Console.WriteLine();
                        Console.WriteLine($"The largest value is {numbers[numbers.Count - 1]}.");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Press ENTER to return to the Main Menu!");
                        Console.ReadLine();
                    }
                    else if (choice == "7")
                    {
                        Console.WriteLine("You've picked option 7 - Print the smallest value.");
                        Console.WriteLine("I will now tell you the smallest value! ");
                        numbers.Sort();
                        Console.WriteLine();
                        Console.WriteLine($"The smallest value is {numbers[0]}.");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Press ENTER to return to the Main Menu!");
                        Console.ReadLine();

                    }
                    else if (choice == "8")
                    {
                        Console.WriteLine("You've picked option 8 - Print the sum and average of the list.");
                        Console.WriteLine("I will now tell you the sum of the whole list! ");
                        Console.WriteLine();
                        Console.WriteLine($"The sum of all {numbers.Count} numbers is {numbers.Sum()}.");
                        average = numbers.Sum() / numbers.Count;
                        Console.WriteLine();
                        Console.WriteLine($"The average is about {average}.");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Press ENTER to return to the Main Menu!");
                        Console.ReadLine();

                    }
                    else if (choice == "9") // Most frequent #
                    {
                        Console.WriteLine("You've picked option 9 - Determine the most frequent number ");
                        Console.WriteLine();
                        numbers.Sort();
                        occurences = 1;
                        maxOccur = 0;
                        for (int i = 1; i < numbers.Count; i++)
                        {
                            if (numbers[i] == numbers[i - 1])
                            {
                                occurences += 1;
                            }
                            else
                            {
                                occurences = 1;
                            }

                            if (occurences > maxOccur)
                            {
                                maxOccur = occurences;
                                mostPopularNum.Clear();
                                mostPopularNum.Add(numbers[i]);
                            }
                            else if (occurences == maxOccur)
                            {
                                mostPopularNum.Add(numbers[i]);
                            }

                        }
                        Console.WriteLine($"The most frequent number(s) are/is: " + String.Join(", ", mostPopularNum) + $". \nThose number(s) appear {maxOccur} times! ");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Press ENTER to return to the Main Menu!");
                        Console.ReadLine();
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Invalid choice, press ENTER to go back to main menu.");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
