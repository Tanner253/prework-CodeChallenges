using System;

namespace program.cs
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] inputArray = new int[] { 2, 5, 5, 4, 1 };
            int inputInteger = 5;
            Console.WriteLine($"the number you chose was : {inputInteger} ");
            Console.ReadKey();
            Console.WriteLine($"occurences (2) * {inputInteger} = ");
            Console.WriteLine("your score is : ");
            Console.WriteLine(Solution(inputArray, inputInteger));
            

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
    }
}
