namespace Homework3
{
    internal class Program //
    {
        static void Main(string[] args)
        {
            func(); // подставление нужного номера после func для запуска соответствующей части кода на исполнение
            Console.ReadLine();
        }
        static void func1() // 1.	Пользователь вводит 2 числа (A и B). Возвести число A в степень B. 
        {
            Console.Write("Введите число A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите степень B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            double result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            }

            Console.WriteLine($"Результат: {result}");
            Console.ReadKey();
        }
        static void func2() // 2.	Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.

        {
            Console.WriteLine("Введите A:");
            int A = int.Parse(Console.ReadLine());

            int[] numbers = Enumerable.Range(1, 1000).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % A == 0)
                {
                    Console.Write(numbers[i]);
                    if (i < numbers.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }
            }
            Console.ReadLine();
        }
        static void func3() // 3.	Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.

        {
            Console.WriteLine("Введите число A:");
            int A = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            for (int i = 1; i * i <= A; i++)
            {
                if (A % i == 0 && i * i != A)
                {
                    count += 2;
                }
                else if (i * i == A)
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество положительных целых чисел, квадрат которых меньше {A}, равно {count}");
            Console.ReadKey();
        }
        static void func4() // 4.	Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A). Кроме самого не получилось)
        {
            Console.Write("Введите число A: ");
            int number = int.Parse(Console.ReadLine());
            int maxdivide = 1;
            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    maxdivide = i;
                }
            }

            Console.WriteLine($"Наибольший делитель числа {number} равен {maxdivide}");
            Console.ReadKey();
        }
        static void func5() // 5.	Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).
        {
            Console.Write("Введите число A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine("Сумма чисел, кратных числу 7: " + sum);
        }
        static void func6() // 6.	Пользователь вводит 1 положительное число (N). Выведите N-ое число ряда фибоначчи. В ряду фибоначчи каждое следующее число является суммой двух предыдущих. Первое и второе считаются равными 1.
        {
            {
                Console.Write("Введите целое положительное число N: ");
                int n = int.Parse(Console.ReadLine());
                FibonacciHelper(n);
            }
            static void FibonacciHelper(int n)
            {
                if (n <= 0)
                {
                    throw new ArgumentException("число N является положительным");
                }
                else if (n == 1 || n == 2)
                {
                    Console.WriteLine($"Число Фибоначчи {n} равняется {1}");
                }
                else
                {
                    int first = 1;
                    int second = 1;

                    for (int i = 2; i < n; i++)
                    {
                        int result = first + second;
                        first = second;
                        second = result;
                    }

                    Console.WriteLine($" {n}-ое число Фибоначчи {second}");
                }
            }
        }
    }
}
