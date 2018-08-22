using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2a
{
    class Program
    {
        static void Main(string[] args)
        {

            //TODO 1.find the sum of ten numbers between 0 and 100 
            //TODO 2. find avg of the ten numbers 

            int i, x, sum = 0;
            double avg;


            Console.WriteLine("Enter ten grades between 0 and 100:   ");

            for (i = 1; i <= 10; i++)
            {
                Console.Write($"grade {i}:  ");

                x = Convert.ToInt32(Console.ReadLine());

                sum += x;

            }
            avg = sum / 10;

            Console.WriteLine("The sum the of your grades are:{0}", sum);
            Console.ReadLine();
            Console.WriteLine("The Average of your numbers is: {0}", avg);
            Console.ReadLine();

            calculateLetterGrade(avg);
            
            calculateLetterGrade(teacherScores());

            // TODO 3.Calculate letter grades
        }


        static void calculateLetterGrade(double avg)

        {
            string letterGrade;
            letterGrade = "grade";
            switch (avg)
            {
                case double grade when (grade >= 90 && grade <= 100):
                    letterGrade = "A";
                    break;

                case double grade when (grade >= 80 && grade <= 89):
                    letterGrade = "B";
                    break;

                case double grade when (grade >= 70 && grade <= 79):
                    letterGrade = "C";
                    break;

                case double grade when (grade >= 60 && grade <= 69):
                    letterGrade = "D";
                    break;

                case double grade when (grade <= 59):
                    letterGrade = "F";
                    break;

                default:
                    letterGrade = "Z";
                    break;

            }
            Console.WriteLine($"The letter grade is:{letterGrade}");
            Console.ReadLine();


        }

        static int teacherScores()

        {
            int numberOfTests, totalValue = 0;
            float temp;
         
            Console.WriteLine("Please enter the desired amount of test scores you would like to input:  ");
            numberOfTests = Convert.ToInt32(Console.ReadLine());
            if (numberOfTests > 0)
            {
                // loop numberOfTests times, to read all the test grades
                for (int b = 1; b <= numberOfTests; b++)
                {
                    // display this message each time in the loop
                    Console.WriteLine("Please enter grade no. " + b);
                    // read the grade
                    temp = Convert.ToInt32(Console.ReadLine());
                    // if the grade is not between 0 and 100, keep 
                    // asking the user to enter a valid grade
                    while (temp < 0 || temp > 100)
                    {
                        // display this message each time in the loop when user enters invalid number
                        Console.WriteLine("Grade has to be between 0 and 100, explicitely.");
                        // read the new grade
                        temp = Convert.ToInt32(Console.ReadLine());
                    }

                    totalValue += Convert.ToInt32(temp);


                }

                


            }
            return totalValue / numberOfTests;

        }
    }
}
          

