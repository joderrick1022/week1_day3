using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_day3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*         int firstNumber = 2;
                     int secondNumber = 6;


                     if (firstNumber < secondNumber)

                     {
                         // do something
                         concole.WriteLine("you have broken math. Good job!");

                     }
                     else
                     {
                         Console.WriteLine("That makes sense!");
                  */


            /*       Console.WriteLine("what day is today");
                   string userAnswer = Console.ReadLine();

                   if (userAnswer == "monday.")
                   {
                       Console.WriteLine("Back to work");
                   }
                   else if (userAnswer == "Friday")


                           {
                       Console.WriteLine("TGIF");
               }
              */

            /*          Console.WriteLine("how old are you");
                      int userAge = int.Parse(Console.ReadLine());
                      if (userAge < 1)
                      {
                          Console.WriteLine("Your just a baby");
                      }
                      else if (userAge > 1 && userAge < 4)
                      {

                          Console.WriteLine("Yay Toddlers");

                      }
                      else if (userAge >= 4 && userAge < 65)
                      {
                          Console.WriteLine("Life isackward");
                      }
                      else if (userAge >= 65 && userAge < 100)
                      {
                          Console.WriteLine("Enjoy your Retirement");
                      }
                      else
                      {
                          Console.WriteLine("that is really not your age");
                      }
          */
        

            Console.WriteLine("how many points did you earn");
            int pointsEarned = int.Parse(Console.ReadLine());

            switch (pointsEarned)
            {
                case 0:
                    Console.WriteLine("you loose.");
                    break;
                case 1:
                    Console.WriteLine("needs practice");
                    break;

                case 2:
                    Console.WriteLine("oh Target");
                    break;

                case 3:
                    Console.WriteLine("Superstar");
                    break;

                case 4:
                    Console.WriteLine("OverAchiever");
                    break;

                case 5:
                    Console.WriteLine("You Cheated");
                    break;

                default:
                    Console.WriteLine("Invalid score Entered");
                    break;


            }







        }

    }
}
