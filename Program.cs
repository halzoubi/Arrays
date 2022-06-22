using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------Intro to Programming: Arrays-----------------------------
            string firstName = "Michael";
            int age = 40;

            //--------------------------------Creating an Array---------------------------------------
            int[] testScores =
            {
                90, //0
                70, //1
                100 //2 =  length of the array  = 3 - 1
            };

            //--------------------------------Printing elements in the array--------------------------
            Console.WriteLine(testScores[0]);
            Console.WriteLine(testScores[1]);
            Console.WriteLine(testScores[2]);

            //--------------------------------Looping through an Array--------------------------------
            for (int i = 0; i < testScores.Length; i++)
            {
                Console.WriteLine(testScores[i]);
            }

            //-------------------------------Replacing an element in an Array-------------------------
            testScores[1] = 95;
            Console.WriteLine(testScores[1]);

            //------------------------------------------Creating an empty Array-----------------------
            string[] favFoods = new string[4];
            favFoods[0] = "Pizza";
            favFoods[1] = "Pasta";
            favFoods[2] = "Chicken";
            favFoods[favFoods.Length - 1] = "Steak";



        }
    }
}
