using System;

namespace _001_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Console setting
            Console.Title = "Console calculator";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(new string('-', 50));
            #endregion

            Console.WriteLine();
            Console.Write("Введите первое число: ");
            int.TryParse(Console.ReadLine(), out int firstNumber);


            Console.WriteLine();
            Console.Write("Введите математическое действие(+, -, *, /) : ");
            char symbol = char.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Введите второе число: ");
            int.TryParse(Console.ReadLine(), out int secondNumber);

            double result = Program.Calculate(firstNumber, secondNumber, symbol);
            Console.WriteLine();
            Console.Write("Результат: " + result);
            Console.WriteLine();
            // Dalay
            Console.ReadKey();
        }

        public static double Calculate(int first, int second, char mathAction)
        {
            switch(mathAction)
            {
                case '+':
                    return first + second;
                case '-':
                    return first - second;
                case '/':
                    return first / second;
                case '*':
                    return first * second;
                default:
                    return 0;
            }
        }
    }
}
