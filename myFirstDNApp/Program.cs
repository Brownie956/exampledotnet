using System;

namespace myFirstDNApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            var fibonacci_numbers = new System.Collections.Generic.List<int> { 1, 1 };
            int val = program.GetFibonacciNumber(20);
            Console.WriteLine(val);
        }

        public int GetFibonacciNumber(int index){
            var fibonacci_numbers = new System.Collections.Generic.List<int> { 1, 1 };
            for (int i = 0; i < index; i++){
                fibonacci_numbers.Add(fibonacci_numbers[i] + fibonacci_numbers[i + 1]);
            }

            return fibonacci_numbers[fibonacci_numbers.Count - 3];
        }
    }
}
