using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HomeWork2();
        }
        static void HomeWork2()
        {
            Console.WriteLine("Введите 10 чисел или введите 0 чтобы завершить ввод");
            

            int inputCount  = 0;
            int[] numbers = new int[10];


            while (inputCount < 10)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[inputCount] = number;

                inputCount++;

                if (number == 0)
                    break;
            }

            int sum = 0;
            int cont = 0;


            foreach (int val in numbers)
            {
                
                
            }
        }

        static void HomeWork1()
        {
            Console.WriteLine("Введите какое кол-во чисел Фибоначчи, которое вы хотите сгенерировать");
            int number = int.Parse(Console.ReadLine());
            int[] Fibanachi = new int[number];

            int x1 = 0;
            int x2 = 1;

            Fibanachi[0] = x1;
            Fibanachi[1] = x2;

            for (int i = 2; i < number; i++)
            {
            

                int sum = x1 + x2;
                Fibanachi[i]= sum;

                x1 = x2;
                x2 = sum;



            }

            foreach(int chislo in Fibanachi)
            {
                Console.WriteLine(chislo);
            }

        }
        static void SwitchCase()
        {
            int month = int.Parse(Console.ReadLine());

            string season = string.Empty;


            switch (month)
            {
                case 1: // Объединение кейсов 
                case 2:
                case 12:
                    season = "Whinter";
                    break;
                default:
                    throw new AggregateException("I don't now");

            }
            Console.WriteLine(season);


            Console.ReadLine();
            int weddingYears = int.Parse(Console.ReadLine());

            string name = string.Empty;

            switch (weddingYears)
            {
                case 5:
                    name = "Деревнна свадьба";
                    break;
                default:
                    name = "Сема пидр";
                    break ;
            }
            Console.WriteLine(name);
        }
        static void BreakContinie()
        {
            int[] numbers3 = {0, 1, 2, 3, 4, 5, 6, 7};
            foreach(int number in numbers3)
            {
                if (number == 3)
                    continue;
                Console.WriteLine(number);
            }

            Console.ReadLine();
            int[] numbers1 = { 0, 3, 2, 1, 5, 4, 6, 7, 8, 9 };
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

            for (int i = 0; i < numbers1.Length; i++)
            {
                Console.WriteLine($"Number={numbers1[i]}");
                for (int j = 0; j < letters.Length; j++)
                {
                    if (numbers1[i] == j)
                    {
                        break;
                    }
                    Console.Write($" {letters[j]} ");
                }
                Console.WriteLine();
            }


            Console.ReadLine();
            int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (counter == 3)
                {
                    break;
                }
                for (int j = i + 1; j < numbers.Length; j++)// Циклы для нахождения пары чисел в массиве
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI};{atJ}. Indexes ({i};{j})");
                        counter++;
                    }
                    if (counter == 3)
                    {
                        break;
                    }
                }
            }
        }
        static void WhileDoWhile()
        {
            //string YesNO = Console.ReadLine();
            //while (YesNO == "No")
            //{
            //    Console.WriteLine("Sema gay?");
            //    YesNO = Console.ReadLine();
            //}
            //Console.WriteLine("I know)");

            //do
            //{
            //    Console.WriteLine("DO\\while");
            //    Console.WriteLine("Sema gay?");
            //    YesNO = Console.ReadLine();
            //}
            //while (YesNO == "No");

            int[] numbers = {1,2,3,4,5};
            int i = numbers.Length - 1;
            while(i>=0)
            {
                Console.WriteLine(numbers[i]);
                i--;
            }
        }
        static void NesteFor()
        {
            int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7,-1,-3, 1, 7 };
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)// Циклы для нахождения пары чисел в массиве
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI};{atJ}. Indexes ({i};{j})");
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)// Циклы для нахождения три чисел в массиве
                {
                    for (int k = j +1; k < numbers.Length; k++)
                    {


                        int atI = numbers[i];
                        int atJ = numbers[j];
                        int atK = numbers[k];
                        if (atI + atJ + atK == 0)
                        {
                            Console.WriteLine($"Pair ({atI};{atJ};{atK}. Indexes ({i};{j};{k})");
                        }
                    }
                }
            }
        }
        static void ForForech()
        {
            int [] numers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < numers.Length; i++)
            {
                Console.Write(numers[i] + " ");
            }
            Console.WriteLine();
            for (int i = numers.Length - 1 ; i>=0 ; i--)// Выводит числа из массива в обратном порядке
            {
                Console.Write(numers[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < numers.Length; i++)
            {
                if(numers[i] % 2 == 0)
                Console.Write(numers[i] + " ");
            }
            Console.WriteLine();
            foreach(int val in numers)// Этот цикл нужен для того если не нужен итератор
            {
                Console.Write(val + " ");
            }

        }
        static void HomeWorks()
        {
            Console.WriteLine("Enture two integer values");
            int First = int.Parse(Console.ReadLine());
            int Second = int.Parse(Console.ReadLine());
            if (First > Second)
            {
                Console.WriteLine($"Number {First}");
            }
            else if (Second > First)
            {
                Console.WriteLine($"Number {Second}");
            }
            else
            {
                Console.WriteLine("These numbers are equal");
            }
        }
        static void ifElse()
        {
            var age = int.Parse(Console.ReadLine());
            string description = age > 18 ? "You can drink alcohol" : "You shuold get a bit odlder"; //Это тернарный операратор
            Console.WriteLine(description);                                                          //Тоже самое, что и внизу

            if (age >= 18)
            {
                Console.WriteLine("You can drink alcohol");
            }
            else
            {
                Console.WriteLine("You shuold get a bit odlder");
            }
        }
    }
}
