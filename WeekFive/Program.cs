using System;
using System.Collections.Generic;

namespace WeekFive
{
    class Program
    {

        static void NumberFour()
        {
            int ticks = Environment.TickCount;
            int seconds = ticks/1000, minutes = seconds / 60, hours = minutes / 60, days = hours / 24 ;
            Console.WriteLine("{0} days, {1} hours, {2} minutes", days, hours % 24, minutes % 60);
        }

        static void NumberNine()
        {
            Console.WriteLine("Enter the end date, formatted as MM/DD/YYYY");
            DateTime end = DateTime.Parse(Console.ReadLine());

            List<List<int>> holidays = new List<List<int>>
            {
                new List<int>{1, 1},
                new List<int>{6, 19},
                new List<int>{7, 4},
                new List<int>{11, 11},
                new List<int>{12, 25}
            };

            List<List<int>> workingSaturdays = new List<List<int>>
            {
                new List<int>{11, 6},
                new List<int>{12, 4},
                new List<int>{1, 8},
                new List<int>{2, 5},
                new List<int>{3, 5}
            };
            int daycount = 0;


            
            for (DateTime date = DateTime.Now; date <= end; date = date.AddDays(1.0))
            {
                List<int> currentDay = new List<int> { date.Month, date.Day };
               
                if( 
                    workingSaturdays.Contains(currentDay) && 
                    !(holidays.Contains(currentDay))
                  )
                {
                    daycount++;
                }

                if ((date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday) &&
                    !(holidays.Contains(currentDay))
                   )
                {
                    daycount++;
                }
            }

            Console.WriteLine("There will be {0} working days", daycount);
        }

        static void NumberTen()
        {
            int sum = 0;
            Console.WriteLine("Enter a set of integers, seperated by spaces");
            string userInput = Console.ReadLine();

            string[] splitArray = userInput.Split(" ");

            foreach (string element in splitArray)
            {
                sum += int.Parse(element);
            }

            Console.WriteLine(sum);
        }

        static void NumberEleven()
        {
            string[] phrases = new string[]
            {
                "The product is excellent.", "This is a great product.", 
                "I use this product constantly.", "This is the best product from this category."
            };

            string[] stories = new string[]
            {
                "Now I feel better.", "I managed to change.", "It made some miracle.", 
                "I can’t believe it, but now I am feeling great.", "You should try it, too. I am very satisfied."
            };

            string[] authorFirst = new string[]
            {
                "Dayan", "Stella", "Hellen", "Kate"
            };

            string[] authorLast = new string[]
            {
                "Johnson", "Peterson", "Charls"
            };

            string[] cities = new string[]
            {
                "London", "Paris", "Berlin", "New York", "Madrid"
            };

            Random random = new Random();

            Console.WriteLine("{0} {1} -- {2} {3}, {4}", phrases[random.Next(phrases.Length)], stories[random.Next(stories.Length)], authorFirst[random.Next(authorFirst.Length)], authorLast[random.Next(authorLast.Length)], cities[random.Next(cities.Length)]);

        }

        static void Main(string[] args)
        {
            //NumberFour();
            //NumberNine();
            //NumberTen();
            NumberEleven();
        }
    }
}
