using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10 - DONE

            var numbers = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};



            /* Create two Lists of type int. - DONE
             * Name one List "evens" - DONE
             * Name the other List "odds" - DONE
             */

            var evens = new List<int>();
            var odds = new List<int>();

            /* Using either a foreach or for loop, - DONE
             * nest an if statement to check to see
             *  if a number is even or odd. - DONE
             * Then add those numbers to either the evens List
             * or the odds List - DONE
             */

            foreach (var num in numbers)
                {
                    if (num % 2 == 0)
                    {
                        evens.Add(num);
                    }
                    else
                    {
                        odds.Add(num);
                    }
                }

            /* Now using foreach or for loops,
             * display each List of even and odd numbers - DONE
             *
             * Try to be creative in your display
             */

            Console.WriteLine("True or False: I love even numbers!");
            var evenOrOdd = bool.Parse(Console.ReadLine());

            if (evenOrOdd == true)
                {
                    Console.WriteLine("Even it is!");

                    foreach (var num in evens)
                    {
                        Console.WriteLine(num);  
                    }

                    Console.WriteLine("But we cannot forget about the odd numbers, so here they are.");

                    foreach (var num in odds)
                    {
                        Console.WriteLine(num);
                    }
            }
            else
                {
                    Console.WriteLine("Odd it is!");

                    foreach (var num in odds)
                    {
                        Console.WriteLine(num);
                    }

                    Console.WriteLine("But we cannot forget about the even numbers, so here they are.");

                    foreach (var num in evens)
                    {
                        Console.WriteLine(num);
                    }
            }

        }
    }
}
