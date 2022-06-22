using System;
using System.Linq;

namespace ArrayLessonPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Michael";
            int age = 40;
            bool isBranchManager = true;

            string[] employees = {
            "Michael",
            "Jim",
            "Pam",
            "Dwight",
            "Kelly"
            };

            Console.WriteLine(employees[1]);

            Console.WriteLine(employees[4]);
            //OR
            Console.WriteLine(employees[employees.Length - 1]);

            Console.WriteLine(employees[3]);
            employees[3] = "Erin";
            Console.WriteLine(employees[3]);

            int[] examScores = new int[4];


            examScores[0] = 98;
            examScores[1] = 95;
            examScores[2] = 100;
            examScores[3] = 93;


            Console.WriteLine(examScores[0]);
            Console.WriteLine(examScores[1]);
            Console.WriteLine(examScores[2]);
            Console.WriteLine(examScores[3]);


            for (int i = 0; i < examScores.Length; i++)
            {
                Console.WriteLine(examScores[i]);
            }



            foreach (int examScore in examScores)
            {
                Console.WriteLine("The exam score is: " + examScore);
            }

            Console.WriteLine("The lowest exam score is " + examScores.Min());
            Console.WriteLine("The highest exam score is " + examScores.Max());
            Console.WriteLine("The average is " + examScores.Average());

            Array.Sort(examScores);
            Array.Reverse(examScores);

            foreach (int x in examScores)
            {
                Console.WriteLine("Sorted " + x);
            }



            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("Hello and welcome to the NMC CIT Programs Portal! Please list each NMC CIT Program below!");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");

            string[] programs = new string[7];

            for (int i = 0; i < programs.Length; i++)
            {
                programs[i] = Console.ReadLine();
            }

            Array.Sort(programs);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("Here are the NMC Programs in Alphabetical order!");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");

            for (int i = 0; i < programs.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + programs[i]);
            }


        }
    }
}
