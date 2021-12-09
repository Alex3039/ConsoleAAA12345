using System;

namespace ConsoleAAA12345
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "Работа с консолью";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            // Console.WriteLine("Hello World!");
            int kk = 0;
            Console.Write("Введите числа: ");
            string s = Console.ReadLine();
            s = s.Replace(' ', ','); // add zapatua
            string[] array = s.Split(','); // data

            for (int i = 0; i < array.Length; i++)
                Console.WriteLine($"Массив чисел: { array[i] }");

            for (int a = 0; a < array.Length; a++)
                kk += Convert.ToInt32(array[a]);
            Console.WriteLine($"Сумма: { kk }");

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
