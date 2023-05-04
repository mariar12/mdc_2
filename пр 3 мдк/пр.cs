using System;

class Program
{
static void Main()
{
   double a, x, b0, bk, delta_b, R, b;
   Console.WriteLine("введите a");
    a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("введите x");
    x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("введите b0");
    b0 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("введите bk");
    bk = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("введите delta_b");
    delta_b = Convert.ToDouble(Console.ReadLine());
   
   for (b = b0; b <= bk; b += delta_b)
{
R = (2.4 * Math.Cos(Math.Pow(a, 3)) + Math.Sqrt(b * b - x))/(Math.Exp(a)+b);


Console.WriteLine("R = "+ Math.Round(R,4));
}
}
}

using System;

class Program
{
    static void Main()
    {
        double a, x, b0, bk, delta_b, R, b;
        Console.WriteLine("Введите a");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите x");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b0");
        b0 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите bk");
        bk = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите delta_b");
        delta_b = Convert.ToDouble(Console.ReadLine());
        
        b = b0;
        while (b <= bk)
        {
            R = (2.4 * Math.Cos(Math.Pow(a, 3)) + Math.Sqrt(b * b - x)) / (Math.Exp(a) + b);
            Console.WriteLine("R = " + Math.Round(R, 4));
            b += delta_b;
        }
    }
}

