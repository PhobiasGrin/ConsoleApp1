using System;
using System.Xml.Linq;

namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            func10(); // подставление нужного номера после func для запуска соответствующей части кода на исполнение
            Console.ReadLine();
        }
        // Двумерные массивы
        static void func1() // Задача 1. Найти минимальный элемент массива
        {
            int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int minElement = mas[0, 0];

            for (int i = 0; i < mas.GetLength(0); i++)
                for (int j = 0; j < mas.GetLength(1); j++)
                    if (mas[i, j] < minElement)
                        minElement = mas[i, j];

            Console.WriteLine($"Минимальный элемент массива: {minElement}");
            Console.ReadKey();
        }
        static void func2() // Задача 2. Найти максимальный элемент массива
        {
            int[,] mas2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int maxElement = mas2[0, 0];
            for (int i = 0; i < mas2.GetLength(0); i++)
                for (int j = 0; j < mas2.GetLength(1); j++)
                    if (mas2[i, j] > maxElement)
                        maxElement = mas2[i, j];
            Console.WriteLine($"Максимальный элемент массива: {maxElement}");
            Console.ReadKey();
        }
        static void func3() // Задача 3. Найти индекс минимального элемента массива
        {
            int[,] arr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int min = arr[0, 0];
            int row = 0;
            int col = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        row = i;
                        col = j;
                    }
                }
            }
            Console.WriteLine($"Индекс минимального элемента двумерного массива: [{row}, {col}]");
        }
        static void func4() // Задача 4. Найти индекс иаксимального элемента массива
        {
            int[,] arr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int max = arr[0, 0];
            int row = 0;
            int col = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        row = i;
                        col = j;
                    }
                }
            }
            Console.WriteLine($"Индекс максимального элемента двумерного массива: [{row}, {col}]");
        }
        static void func5() // Задача 5. Найти количество элементов массива, которые больше всех своих соседей одновременно
        {
            int[,] arr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int count = 0;
            for (int i = 1; i < arr.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < arr.GetLength(1) - 1; j++)
                {
                    if (arr[i, j] > arr[i - 1, j] && arr[i, j] > arr[i + 1, j] && arr[i, j] > arr[i, j - 1] && arr[i, j] > arr[i, j + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Количество элементов двумерного массива, которые больше всех своих соседей одновременно: {count}");
        }
        static void func6() // Задача 6. Отразите массив относительно его главной диагонали
        {
            int[,] arr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = i + 1; j < arr.GetLength(1); j++)
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[j, i];
                    arr[j, i] = temp;
                }
            }
            Console.WriteLine("Отображение:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        //static void func7() // Задача 7. Отразите массив относительно его главной диагонали (не решил)
        static void func8() // Задача 8. Дан двухмерный массив A[1..m,1..n]. Написать программу построения
        // одномерного массива B[1..m], элементы которого соответственно равны:
        // а) суммам элементов строк:
        {
            double[,] A = new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            double[] B = new double[A.GetLength(0)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                double sum = 0;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    sum += A[i, j];
                }
                B[i] = sum;
            }

            Console.WriteLine("Массив суммы элементов строк:");
            for (int i = 0; i < B.Length; i++)
            {
                Console.Write($"{B[i]} ");
            }
        }
        static void func9()//б) произведениям элементов строк:
        {
            double[,] A = new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            double[] B = new double[A.GetLength(0)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                double product = 1;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    product *= A[i, j];
                }
                B[i] = product;
            }

            Console.WriteLine("Массив произведения элементов строк:");
            for (int i = 0; i < B.Length; i++)
            {
                Console.Write($"{B[i]} ");
            }
        }
        static void func10()//б) среднее арифметическое элементов строк:
        {
            double[,] A = new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            double[] B = new double[A.GetLength(0)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                double sum = 0;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    sum += A[i, j];
                }
                B[i] = sum / A.GetLength(1);
            }

            Console.WriteLine("Массив среднее арифметическое элементов строк:");
            for (int i = 0; i < B.Length; i++)
            {
                Console.Write($"{B[i]} ");
            }
        }
    }
}
