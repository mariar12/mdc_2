using System;

class Program {
    static void Main() {
        double x, c1, c2;
        Console.WriteLine("Введите x:");
        x = Convert.ToDouble(Console.ReadLine());
       

        // Вычисляем гиперболический котангенс с помощью встроенных функций гиперболических тригонометрических функций
        c1 = 1 / Math.Tanh(x);

        // Вычисляем гиперболический котангенс с помощью формулы coth(x) = (e^x + e^-x) / (e^x - e^-x)
        c2 = (Math.Exp(x) + Math.Exp(-x)) / (Math.Exp(x) - Math.Exp(-x));

        Console.WriteLine("первый способ = " + c1);
        Console.WriteLine("второй способ = " + c2);
    }
}
