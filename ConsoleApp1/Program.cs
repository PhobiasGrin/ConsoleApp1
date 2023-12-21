namespace Homework2
{
    internal class Program // Не успел сделать задачи номер 5 и номер 7, 4-ю вроде разбирали на уроке.
    {
        static void Main(string[] args)
        {
            func1(); // подставление нужного номера после func для запуска соответствующей части кода на исполнение
            Console.ReadLine();
        }
        static void func1() // Задача номер 6 
        {
            double x, y, x0, y0, radius;
            Console.Write("Введите координату Х точки M: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Введите координату Y точки M: ");
            y = double.Parse(Console.ReadLine());
            Console.Write("Введите координату Х0 центра круга: ");
            x0 = double.Parse(Console.ReadLine());
            Console.Write("Введите координату Y0 центра круга: ");
            y0 = double.Parse(Console.ReadLine());
            Console.Write("Введите радиус круга: ");
            radius = double.Parse(Console.ReadLine());

            double distance = Math.Sqrt((x - x0) * (x - x0) + (y - y0) * (y - y0)); // формула подсчета расстояния между двумя точками

            if (distance <= radius) // условие попадания точки в круг / границу круга или вне круга
            {
                Console.WriteLine("Точка M находится внутри или на границе круга.");
            }
            else
            {
                Console.WriteLine("Точка M находится вне круга.");
            }
        }
        static void func2() // Задача номер 1
        {
            Console.Write("Введите число A: ");
            double A = double.Parse(Console.ReadLine());

            Console.Write("Введите число B: ");
            double B = double.Parse(Console.ReadLine());

            if (A > B)
            {
                Console.WriteLine($"Сумма A плюс B = {A + B}");
            }
            else if (A == B)
            {
                Console.WriteLine($"Произведение A умножить на B = {A * B}");
            }
            else
            {
                Console.WriteLine($"Разница A минус B = {A - B}");
            }
        }
        static void func3() // Задача номер 2

        {
            Console.Write("Введите координату X: ");
            double X = double.Parse(Console.ReadLine());

            Console.Write("Введите координату Y: ");
            double Y = double.Parse(Console.ReadLine());

            if (X > 0 && Y > 0) // если X,Y больше нуля
            {
                Console.WriteLine("Точка принадлежит первой четверти.");
            }
            else if (X < 0 && Y > 0) // если X меньше нуля, Y больше нуля
            {
                Console.WriteLine("Точка находится во второй четверти.");
            }
            else if (X < 0 && Y < 0) // если X  меньше нуля, Y больше нуля
            {
                Console.WriteLine("Точка принадлежит третьей четверти.");
            }
            else // остальные условия, например Х > 0, Y < 0; X,Y = 0
            {
                Console.WriteLine("Точка находится в четвертой четверти.");
            }
        }
        static void func4() // Задача номер 3

        {
            Console.WriteLine("Введите первое число:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            int C = Convert.ToInt32(Console.ReadLine());
            if (A < B && A < C)
            {
                Console.Write(A);
                Console.WriteLine(Math.Min(B, C));
                Console.WriteLine(Math.Max(B, C));
            }
            else if (B < A && B < C)
            {
                Console.WriteLine(B);
                Console.WriteLine(Math.Min(A, C));
                Console.WriteLine(Math.Max(A, C));
            }
            else if (C < B && C < A)
            {
                Console.WriteLine(C);
                Console.WriteLine(Math.Min(A, B));
                Console.WriteLine(Math.Max(A, C));
            }
        }
    }
}
