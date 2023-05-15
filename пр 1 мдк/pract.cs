using System;

class Program {
    static void Main() {
        double x;
        
        x = ((2.7 - 0.8) * 2 * 1/3) / (((5.2 - 1.4) / 3/7)) - 2.625 + 8 * 9/11 - (((7 / (30 - 93 * 5/18)) * 2 * 1/4) / 0.2) + Math.Pow(Math.PI, 6);

        Console.WriteLine("Результат: " + x);
    }
}
