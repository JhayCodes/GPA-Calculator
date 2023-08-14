using System;

namespace GPAcalculator
{
    class Program
    {
        public static void CalGPA()
        {
            double result;
            Console.WriteLine("How many courses did you do for the semester?");
            int courseNum = Convert.ToInt32(Console.ReadLine()); //input given by user

            double[] gpa = new double[courseNum]; //an array of type double to store grades
            int[] credithr = new int[courseNum]; //an array of type int to store hours per corresponding grades

            Console.WriteLine("Enter grades: ");
            //Takes the grades from user.
            for (int i = 0; i < courseNum; i++)
            {

                string userGrade = Console.ReadLine().ToLower();
                switch (userGrade) //switch statement to convert the grades to gradepoint
                {
                    case "a":
                        gpa[i] = 4.0;
                        break;

                    case "b+":
                        gpa[i] = 3.5;
                        break;
                    case "b":
                        gpa[i] = 3.0;
                        break;
                    case "c+":
                        gpa[i] = 2.5;
                        break;
                    case "c":
                        gpa[i] = 2.0;
                        break;
                    case "d+":
                        gpa[i] = 1.5;
                        break;
                    case "d":
                        gpa[i] = 1.0;
                        break;
                    case "f":
                        gpa[i] = 0;
                        break;

                }

            }

            Console.WriteLine("Enter corresponding credit hours:");

            for (int i = 0; i < courseNum; i++) // takes input from user and stores credit hours in an array
            {
                int cHr = Convert.ToInt32(Console.ReadLine());
                credithr[i] = cHr;
            }

            double totalGPA = 0;
            int totalHours = 0;
            //summation of individual GPA
            for (int i = 0; i < courseNum; i++)
            {
                totalGPA = totalGPA + (credithr[i] * gpa[i]);
            }
            //summation of individual credit hours
            for (int i = 0; i < courseNum; i++)
            {
                totalHours = totalHours + credithr[i];
            }
            // Total GPA
            result = totalGPA / totalHours;
            Console.WriteLine();

            Console.WriteLine("Your GPA for this semester is {0:F2} ", result); //prints out your gpa.

            //takes your gpa, checks for the corresponding class and prints out the class.
            if (result >= 3.6)
            {
                Console.WriteLine("You're in First Class");
            }
            else if (result >= 3.0 && result < 3.6)
            {
                Console.WriteLine("You're in Second Upper Class");
            }
            else if (result >= 2.5 && result < 3)
            {
                Console.WriteLine("You're in Second Lower class");
            }
            else if (result >= 2 && result < 2.5)
            {
                Console.WriteLine("You're in Third Class");
            }
            else if (result >= 1.5 && result < 1.99)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail!!");
            };

        }

        static void Main(string[] args)
        {
            
            
                Console.WriteLine("Welcome...\nDo you want to calculate your GPA? Type 'Yes' or 'No'.");
                while(Console.ReadLine().ToLower() == "yes")
                {
                    CalGPA();
                Console.WriteLine("");


                    
                }
                {
                    Console.WriteLine("Thanks ");
                }

        }
    }
}
