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
      
        
    }
}
