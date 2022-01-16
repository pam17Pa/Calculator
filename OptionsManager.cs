using System;

namespace GitExercise
{
    public static class OptionsManager
    {
        public static string[] OptionsList = {
            "a - Add",
            "s - Substract",
            "m - Multiply",
            "d - Divide"
        };

        public static void Add(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
        public static void Substract(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }
        public static void Multiply(double a, double b)
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
        }
        public static void Divide(double a, double b)
        {
            Console.WriteLine($"{a} / {b} = {a / b}");
        }


    }
}
