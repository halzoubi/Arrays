using System;

namespace ArraysLessonPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------Intro to Programming: Arrays-----------------------------
            string firstName = "Michael";
            int age = 40;
            bool isGeneralManager = true;

            //--------------------------------Creating an Array-----------------------------------------------------
            int[] testScores =
            {
                95, //0
                70, //1
                100 //2
            };

            //--------------------------------Printing elements in the array-----------------------------------------------------
            Console.WriteLine(testScores[0]);
            Console.WriteLine(testScores[1]);
            Console.WriteLine(testScores[2]);

            //--------------------------------Looping through an Array-----------------------------------------------------
            for (int i = 0; i < testScores.Length; i++)
            {
                Console.WriteLine(testScores[i]);
            }

            //-------------------------------Replacing an element in an Array-------------------------------------------------------
            testScores[1] = 90;
            Console.WriteLine(testScores[1]);

            //------------------------------------------Creating an empty Array-----------------------------------------
            string[] favFoods = new string[4];

            favFoods[0] = "Pizza";
            favFoods[1] = "Chicken";
            favFoods[2] = "Steak";
            favFoods[3] = "Pasta";

            //---------------------------------------------Job Openings Exercise---------------------------------------------------

            string[] newEmployees = new string[5];

            Console.WriteLine("Please enter the five applicants who will be joining your team.");

            for (int i = 0; i < newEmployees.Length; i++)
            {
                newEmployees[i] = Console.ReadLine();
            }

            for (int i = 0; i < newEmployees.Length; i++)
            {
                Console.WriteLine("Hello " + newEmployees[i] + "! Welcome to our organization!");
            }
        }
    }
}
