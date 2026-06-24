using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 5, b = 2;
            Console.WriteLine($"a + b = {a + b}");
            //addition
            /*jkjkjk
             * klklkl
             * klklklkl
            */
            // Arrays
            string[] cars = new string[3];
            cars[0] = "Volvo";
            cars[1] = "BMW";
            cars[2] = "Ford";
            Console.WriteLine($"First car : {cars[0]}");
            Console.WriteLine($"Second car : {cars[1]}");
            Console.WriteLine($"Third car : {cars[2]}");
            // List (Dynamic array)
            List<int> numbers = new List<int>();
            numbers.Add(64);
            numbers.Add(128);
            numbers.Add(256);
            Console.WriteLine($"First number: {numbers[0]}");
            Console.WriteLine($"Second number: {numbers[1]}");
            Console.WriteLine($"Third number: {numbers[2]}");
            numbers.Remove(128);
            Console.WriteLine($"Second number: {numbers[1]}");
            numbers.Add(100);
            numbers[0] = numbers[1] + numbers[2];
            Console.WriteLine($"First number: {numbers[0]}");
            // Dictionary (Key-Value Paris)
            Dictionary<string, float> products = new Dictionary<string, float>();
            products.Add("Apple", 0.99f);
            products.Add("Banana", 0.59f);
            products.Add("Orange", 0.79f);
            Console.WriteLine($"Apple: ${products["Apple"]}");
            Console.WriteLine($"Banana: ${products["Banana"]}");
            Console.WriteLine($"Orange: ${products["Orange"]}");

            // If-Else Statement
            if (a > b) Console.WriteLine("Alright");

            if (products.Count > 10) Console.WriteLine("Products available:");
            else Console.WriteLine("Products unavailable:");

            int age = 15;
            if (age >= 18) Console.WriteLine("You are an adult.");
            else if (age >= 13) Console.WriteLine("You are a teenager.");
            else Console.WriteLine("You are not a child.");

            //Switch Statement
            char grade = 'B';
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'B':
                    Console.WriteLine("Well done");
                    break;
                case 'C':
                    Console.WriteLine("Good");
                    break;
                case 'D':
                    Console.WriteLine("You passed");
                    break;
                case 'F':
                    Console.WriteLine("Failed");
                    break;
                default:
                    Console.WriteLine("invalid grade");
                    break;

            //switch Condition
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"For loop iteration: {i}");
            }

            //For loop Condition
            bool isTrue = true;
            int Counter = 0;
            while (isTrue)
            {
                Console.WriteLine("Eternity");
                if (Counter == 10)
                {
                    isTrue = false;
                }
                Counter++;
            }

            // while loop Condition
            foreach (string car in cars)
            {
                Console.WriteLine($"Car: {car}");
            }
            //foreach Condition

            // function
            string Hello(string name)
            {
                return $"Hello, {name}!";
            }

            /* string h = Hello("Alice");
            Console.WriteLine(h); */

            Console.WriteLine(Hello("Alice"));
            Console.WriteLine("ling");

            void NumberCompare(int x, int y)
            {
                if (x > y) Console.WriteLine ($"{x} is greater than {y}");
                else if (x < y) Console.WriteLine($"{x} is less than {y}");
                else Console.WriteLine($"{x} is equal to {y}");
            }
            NumberCompare(5, 10);


            List<Player> players = new List<Player>();

            for (int i = 0; i < 3; i++)
            {
                players.Add(new Player());
            }
            players[0].Name = "Alice";
            players[1].Name = "Bob";
            players[2].Name = "Charlie";
            players[0].Level = 10;
            players[1].Level = 20;
            players[2].Level = 30;

            foreach (Player pl in players)
                Console.WriteLine($"Player: {pl.Name}, Level: {pl.Level}");
        }
    }
    class Player
    {
        string name;
        int level;

        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }

        public int Level
        {
            get { return Level; }
            set { Level = value; }
        }
        // Constructor
        public Player(string name = "Unknown", int level = 1)
        {
            this.Name = name;
            this.Level = level;
        }

    }
}