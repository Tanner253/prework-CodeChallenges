using System;
using System.Linq;

namespace program.cs
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] inputArray = new int[] { 2, 5, 5, 4, 1 };
            int inputInteger = 5;
            int givenYear = 2016;
            int[] arrayThree = new int[] {1,3,2};
           
            Console.WriteLine($"the number you chose was : {inputInteger} ");
            Console.ReadKey();
            Console.WriteLine($"occurences (2) * {inputInteger} = ");
            Console.WriteLine("your score is : ");
            Console.WriteLine(Solution(inputArray, inputInteger));
            Console.WriteLine($"is {givenYear}  a leap year? 1 = yes 0 = no");
            Console.WriteLine(SolutionTwo(givenYear));
            Console.WriteLine($"is the sequence perfect? 1 = yes 0 = no :");
            Console.WriteLine(SolutionThree(arrayThree));
           
            Console.WriteLine(solutionFourSum(SolutionFour()));
            
        }
        public static int Solution(int[] inputArray, int inputInteger)
        {
            int counter = 0;
            for ( var i = 0; i < inputArray.Length; i++)
            {
                if(inputArray[i] == inputInteger)
                {
                    counter++;
                }
            }
            return counter * inputInteger;
            
        }
        public static int SolutionTwo(int givenYear)
        {   
            if(givenYear % 4 == 0 && givenYear % 100 != 0){
                return 1;
            }else
            {
                return 0;
            }
            
        }
        public static int SolutionThree(int[] array)
        {
            int prod = 1;
            foreach (int val in array)
            {
                prod *= val;
            }
            int arraySum = array.Sum();
            if (arraySum == prod)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public static int[,] SolutionFour()
            {
            Console.Write("Please choose the length of your array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please choose the width of your array: ");
            int width = Convert.ToInt32(Console.ReadLine());
            int[,] myArray = new int[width, length];

            
            
            for (int m = 0; m < width; m++)
            {
                for (int n = 0; n < length; n++)
                {
                    myArray[m, n] = Convert.ToInt32(Console.ReadLine()); 
                    
                }
                
            }

            return myArray;
        }
        public static int[] solutionFourSum(int[,] twoDArrays)
        {
            int chosenArrayLength = twoDArrays.GetLength(1);
            int chosenArrayWidth = twoDArrays.GetLength(0);

            int[] sums = new int[chosenArrayWidth];

            for (int i = 0; i < chosenArrayWidth; i++)
            {
                for (int j = 0; j < chosenArrayLength; j++)
                {
                    sums[i] += twoDArrays[i, j];
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", sums));
            return sums;
        }
    }
}
