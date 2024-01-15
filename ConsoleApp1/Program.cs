using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Square
{
    using System;
    class Square
    {
        public double sideLength;
        public string color;
        public double area;
        public Square(double sideLength, string color)
        {
            this.sideLength = sideLength;
            this.color = color;
            area = sideLength * sideLength;
        }
        public void PrintInfo()
        {
            Console.WriteLine("У квадрата со стороной {0} см, цвет {1}, площадь равняется {2} кв. см.", sideLength, color, area);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Square greenSquare = new Square(5, "зеленый");
            Square blueSquare = new Square(2, "синий");
            Square cyanSquare = new Square(15, "голубой");
            Console.WriteLine("Информация о фигурах:");
            greenSquare.PrintInfo();
            blueSquare.PrintInfo();
            cyanSquare.PrintInfo();
            greenSquare = new Square(blueSquare.sideLength * 3, "зеленый");
            Console.WriteLine("Информация о зеленом квадрате после изменения длины его стороны:");
            greenSquare.PrintInfo();
        }
    }
}
