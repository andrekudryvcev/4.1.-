using System;

namespace MyNamespace
{
    class Program
    {
        public static void Main(string[] args)
        {
            var myapples = 5;
            var hisapples = 6;
            var hispeares = 5;

            var result = (myapples != hispeares) & (myapples < hisapples);
            Console.WriteLine(result);

            Console.WriteLine("\n***************************************************\n");

            Console.WriteLine("Пример Амперсанда & and &&\n");

            var a = 5 + 6;
            var b = 7 + 8;

            var c = (b == a) & (b > a + 1);
            var d = (b == a) && (b > a + 1);

            Console.WriteLine(c);
            Console.WriteLine(d);

            Console.WriteLine("\n***************************************************\n");

            var a1 = 6;
            var b1 = 7;

            var c1 = (a1 > b1) ^ (a1 != b1);
            Console.WriteLine(c1);

            Console.WriteLine("\n***************************************************\n");

            Console.WriteLine("! - логическое отрицание. Инверсия");

            var inv = true;
            var result1 = !inv;
            Console.WriteLine($"inv до инверсии - {inv}. inv после инверсии - {result1}");

            Console.WriteLine("\n***************************************************\n");

            Console.WriteLine("Условная конструкция. if()..\n");

            var a2 = 6;
            var b2 = 7;

            if (a2 != b2)
            {
                Console.WriteLine("Условие истинно");
            }
            else
            {
                Console.WriteLine("Условие ложно");
            }

            Console.WriteLine("\n***************************************************\n");

            Console.WriteLine("Тернарная операция\n");

            var a3 = 6;
            var b3 = 7;

            var c3 = a3 != b3 ? a3 + b3 : b3;
            Console.WriteLine(c3);

            Console.WriteLine("\n***************************************************\n");

            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
            }
            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
            }

            Console.WriteLine("\n***************************************************\n");




            Console.WriteLine("switch (переключатель)\n");

            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            var color1 = Console.ReadLine();

            switch (color1)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;
                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow");
                    break;
            }




        }
    }
}