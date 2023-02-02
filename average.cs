using System;

    class Program
    {
        public static void Main(string[] args)
        {
            // Нахождение среднего арифметического всех эл. массива;
            int[] numbers = { 2, 5, 13, 7, 6, 4 };
            int sum = 0;
            int index = 0;
            foreach (int number in numbers)
            {
                sum = sum + number;
                index++;
            }
            var arg = (float)sum / index;
            Console.WriteLine(arg);
        Console.ReadLine();
        }
    }