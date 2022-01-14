using AreaLibrary;
using System.Text;

namespace AreaConsoleApp
{
    class Program
    {
        static void Main()
        {
            //Если консоль не отображает кириллицу, как на моем ПК.
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            double area;
            bool isValid;

            Console.WriteLine("Программа для вычесления площади фигур \n");
            Console.WriteLine("Введите цифру 1 для вычесления площади круга");
            Console.WriteLine("Введите цифру 2 для вычесления площади треугольника");

            int selectNumber;
            do
            {
                isValid = int.TryParse(Console.ReadLine(), out selectNumber);
                if (!isValid || selectNumber < 1 || selectNumber > 2)
                {
                    Console.WriteLine("Неправильный ввод. \nВведите цифру 1 или 2!");
                    isValid = false;
                }
            }
            while (!isValid);

            switch (selectNumber)
            {
                case 1:
                    Console.WriteLine("Задайте значение радиуса круга:");
                    var radius = TryParse();
                    var circle = new Circle(radius);
                    area = circle.GetArea();
                    Console.WriteLine("Площадь круга составляет:");
                    Console.WriteLine(area);
                    return;
                case 2:
                    Console.WriteLine("Задайте сторону А треугольника:");
                    var sideA = TryParse();
                    Console.WriteLine("Задайте сторону B треугольника:");
                    var sideB = TryParse();
                    Console.WriteLine("Задайте сторону C треугольника:");
                    var sideC = TryParse();
                    var triangle = new Triangle(sideA, sideB, sideC);
                    area = triangle.GetArea();
                    Console.WriteLine("Площадь треугольника составляет:");
                    Console.WriteLine(area);
                    triangle.RightTriangle();
                    return;
                default:
                    return;
            }
        }
        public static double TryParse()
        {
            double number;
            bool isValid;
            do
            {
                isValid = double.TryParse(Console.ReadLine(), out number);
                if (!isValid || number < 0)
                {
                    Console.WriteLine("Неправильный ввод. \nВведите положительное число!");
                    isValid = false;
                }
            }
            while (!isValid);
            return number;
        }
    }
}