class Program
{
    public static void Task1()
    {
        double a = Convert.ToDouble(Console.ReadLine()); 
        double b = Convert.ToDouble(Console.ReadLine());
        double n = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        double u;
        double k;
        double m;

        if (a * a == 529)
        {
            u = Math.Cos(a);
        }
        else
        {
            u = Math.Sin(a);
        }


        if (a > b)
        {

            k = a * a;
        }
        else if (a == b)
        {
            k = a + b;
        }
        else k = c;

        m = ((n + u) / (k - u)) + Math.Tan(k) - Math.Exp(n + k * k);
        Console.WriteLine(m);   
    }

    public static void Task2()
    {
        int[] numbers = { 4, 2, 1, 3 };
        Array.Sort(numbers);
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

    }

    public static void Main(string[] args)
    {
        Task2();
    }
}