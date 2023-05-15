using System;

class Program
{
static void Main()
{
 
double b, e, a, z, Y;   

Console.WriteLine("vvedite b");
b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("vvedite e");
e = Convert.ToDouble(Console.ReadLine());

// вычисляем a
if (b > 6)
{
    a = b * b + e;
}
else
{
    a = b * b - Math.Cos(e);
}

// вычисляем z
if (b > 8)
{
    z = b;
}
else if (b == 6)
{
    z = b * b * b;
}
else
{
    z = Math.Pow(b, 4);
}

// вычисляем Y
double az = a * z;
if (az == 15)
{
    Y = 5;
}
else if (az < 15)
{
    Y = Math.Tan(a);
}
else
{
    Y = b * Math.Cos(a);
}

Console.WriteLine("Y = "+ Math.Round(Y,4));

}
}
