using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        f1.SetTop(1);
        Console.WriteLine(f1.GetTop());

        Fraction f2 = new Fraction();
        f2.SetBottom(2);
        Console.WriteLine(f2.GetBottom());

        Fraction f3 = new Fraction(3,4);
        Console.WriteLine(f3.GetFractionString(3,4));

        Fraction f4 = new Fraction(3,4);
        Console.WriteLine(f4.GetDecimalValue(3,4));

        Random random= new Random();
        Fraction f5 = new Fraction();

        for (int i = 0; i < 20; i++)
        {
            int topVariable = random.Next(1, 11);
            int bottomVariable = random.Next(1, 11);

            f5.SetTop(topVariable);
            f5.SetBottom(bottomVariable);
            Console.Write($"Fraction {i + 1}: ");
            Console.Write($"string: {f5.GetFractionString(1,11)}");
            Console.WriteLine($" Number: {f5.GetDecimalValue(1,11)}");
        }
    }
}