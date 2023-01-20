/*
Author: Alicia Sullivan
Date: 01/19/2023
Description: C# Console Application Calculating Letter Grades
*/

using System;

namespace Deliverable_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What numeric grade do you expect to receive in ISM 4300? ");

            try
            {

                decimal grade = decimal.Parse(Console.ReadLine());

                string letter;

                if (grade >= 90)

                {
                    letter = "A";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is: " +letter);
                }

                else if (grade >= 80 && grade < 90)

                {
                    letter = "B";
                    Console.WriteLine("Your expected letter grade is: " +letter);
                }

                else if (grade >= 70 && grade <80)
                {
                    letter = "C";
                    Console.WriteLine("Your expected letter grade is: " +letter);
                }

                else if (grade >= 60 && grade < 70)
                {
                    letter = "D";
                    Console.WriteLine("Your expected letter grade is: " +letter);
                }

                else if (grade >= 0 && grade < 60)
                {
                    letter = "F";
                    Console.WriteLine("Your expected letter grade is: " +letter);
                }

            }
            catch
            {
                Console.WriteLine("What numeric grade do you expect to receive in ISM 4300? ");
            }
        }   
    }
}