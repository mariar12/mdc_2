using System;

class Program {
    static void Main() {
        double z, a;
        int n;
        double R = 0;

        Console.Write("Введите z: ");
        z = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите a: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите n: ");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++) {
            double z_i = Math.Pow(z, 2 * i);
            double tg_i = Math.Pow(Math.Tan(z), i);
            double cos_i = Math.Cos(Math.Pow(z, -i));

            R += (Math.Cos(z_i) + a) / Math.Sqrt(Math.Tan(z) + Math.Cos(z_i)) +
                 (Math.Cos(Math.Pow(z_i, 2)) - 2 * a) / Math.Sqrt(Math.Pow(Math.Tan(z), 2) - cos_i) +
                 (Math.Cos(Math.Pow(z_i, 3)) + 3 * a) / Math.Sqrt(Math.Pow(Math.Tan(z), 3) + cos_i);
        }

        Console.WriteLine("R = " + R);
    }
}
