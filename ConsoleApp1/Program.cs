namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            func7(); // подставление нужного номера после func для запуска соответствующей части кода на исполнение
            Console.ReadLine();
        }
        // Одномерные массивы
        static void func() // Задача 1. Найти минимальный элемент массива
        {
            int[] array = { 1, 3, -9, 7, -1, 9, 0, -4, 8 };
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            Console.WriteLine("Минимальный элемент массива: " + min);
        }
        static void func2() // Задача 2. Найти максимальный элемент массива
        {
            {
                int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                int max = array[0];

                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                }
                Console.WriteLine("Максимальный элемент массива: " + max);
            }
        }
        static void func3() // Задача 3. Найти индекс минимального элемента массива
        {
            int[] array = { 5, 4, 3, 2, 1, 6, 7, 8, 9 };
            int min = array[0];
            int minIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }
            }
            Console.WriteLine($"Индекс минимального элемента массива: {minIndex}");
        }
        static void func4() // Задача 4. Найти индекс максимального элемента массива
        {
            int[] array = { 1, 2, 3, 4, 5, 9, 8, 7, 6 };
            int maxValue = array.Max();
            int maxIndex = array.ToList().IndexOf(maxValue);
            Console.WriteLine($"Индекс максимального элемента массива: {maxIndex}");
        }
        static void func5() // Задача 5. Посчитать сумму элементов массива с нечетными индексами
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                sum += array[i];
            }
            Console.WriteLine($"Сумма элементов массива с нечетными индексами: {sum}");
        }
        static void func6() // Задача 6. Сделать реверс массива (массив в обратном направлении)
        {
            // Создаем исходный массив
            int[] originalArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            // Создаем новый массив, который будет содержать реверсированный массив
            int[] reversedArray = new int[originalArray.Length];

            // Проходим по каждому элементу исходного массива
            for (int i = 0; i < originalArray.Length; i++)
            {
                // Записываем последний элемент исходного массива в конец реверсированного массива
                reversedArray[originalArray.Length - i - 1] = originalArray[i];
            }

            // Выводим реверсированный массив на экран
            for (int i = 0; i < reversedArray.Length; i++)
            {
                Console.Write(reversedArray[i]);
                if (i != reversedArray.Length - 1)
                {
                    Console.Write(", ");
                }
            }
        }
        static void func7() // Задача 7. Посчитать количество нечетных элементов массива  
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            int count = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 1)
                    count++;
            }
            Console.WriteLine($"Количество нечетных элементов массива: {count}");
        }
    }
}






