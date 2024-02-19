/*
 * Author: Oscar Mendez
 * Course: COMP-003A
 * Purpose: To replicate the outcome for assignment 5
 */

namespace COMP003A.Assignment5
{
    class Program
    {
        static void Main()
        {

            PrintSeparator();

            Console.Write("Enter a single character: ");
            char triangleCharacter = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Move to the next line

            Console.Write("Enter a positive whole number: ");
            int triangleSize = int.Parse(Console.ReadLine());

            IsoscelesTriangleBuilder(triangleCharacter, triangleSize);

            Characters();

            CharacterInfo("Batman", 1939);
            CharacterInfo("Superman", 1938);
            CharacterInfo("The Flash", 1956);
            CharacterInfo("Green Lantern", 1971);
            CharacterInfo("Iron Man", 1963);
        }

        /// <summary>
        /// Outputs 50 asterisks.
        /// </summary>
        static void PrintSeparator()
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("Triangle Section");
            Console.WriteLine("".PadRight(50, '*'));
        }

        /// <summary>
        /// Outputs a separator string and then prints the provided parameter.
        /// </summary>
        /// <param name="separator">The separator string to be printed.</param>
        static void PrintSeparator(string separator)
        {
            Console.WriteLine(separator);
        }

        /// <summary>
        /// Builds an isosceles triangle using the given character and size.
        /// </summary>
        /// <param name="inputCharacter">Character used to build the triangle.</param>
        /// <param name="size">Size of the triangle.</param>
        static void IsoscelesTriangleBuilder(char inputCharacter, int size)
        {
            for (int i = 1; i <= size; i++)
            {
                Console.WriteLine(new string(inputCharacter, i));
            }

            for (int i = size - 1; i > 0; i--)
            {
                Console.WriteLine(new string(inputCharacter, i));
            }
        }

        /// <summary>
        /// Calculates the age based on the given year.
        /// </summary>
        /// <param name="year">The birth year.</param>
        /// <returns>The calculated age.</returns>
        static int AgeCalculator(int year)
        {
            return DateTime.Now.Year - year;
        }

        /// <summary>
        /// Outputs the name and age of a character based on the given year.
        /// </summary>
        /// <param name="name">The name of the character.</param>
        /// <param name="birthYear">The birth year of the character.</param>
        static void CharacterInfo(string name, int birthYear)
        {
            int age = AgeCalculator(birthYear);
            Console.WriteLine($"{name} is {age} years old.");
        }

        static void Characters()
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("Favorite Characters section");
            Console.WriteLine("".PadRight(50, '*'));
        }
    }
}