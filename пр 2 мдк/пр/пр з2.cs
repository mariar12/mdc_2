using System;

class Program {
    static void Main() {
        double x, y;
        Console.Write("Введите координату X: ");
        x = double.Parse(Console.ReadLine());

        Console.Write("Введите координату Y: ");
        y = double.Parse(Console.ReadLine());

        if (x > 0 && y > 0) {
            Console.WriteLine("Точка лежит в первом квадранте");
        } else if (x < 0 && y > 0) {
            Console.WriteLine("Точка лежит во втором квадранте");
        } else if (x < 0 && y < 0) {
            Console.WriteLine("Точка лежит в третьем квадранте");
        } else if (x > 0 && y < 0) {
            Console.WriteLine("Точка лежит в четвертом квадранте");
        } else if (x == 0 && y == 0) {
            Console.WriteLine("Точка находится в начале координат");
        } else if (x == 0) {
            Console.WriteLine("Точка лежит на оси Y");
        } else {
            Console.WriteLine("Точка лежит на оси X");
        }

        
    }
}

