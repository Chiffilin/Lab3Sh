using System;
using System.Numerics;

public class Example
{
    public static void Main()
    {
        Complex r;
       
        Complex R;
        Console.WriteLine("Введите первое комплексное число : ");
        Console.WriteLine("Введите действительную часть: ");
        double a1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите мнимую часть: ");
        double a2 = Convert.ToDouble(Console.ReadLine());
        Complex a = new Complex(a1,a2);
        Console.WriteLine(a);

        Console.WriteLine("Введите второе комплексное число : ");
        Console.WriteLine("Введите действительную часть: ");
        double b1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите действительную часть: ");
        double b2 = Convert.ToDouble(Console.ReadLine());
        Complex b = new Complex(b1, b2);
        Console.WriteLine(b);

        Console.WriteLine("Введите третье комплексное число : ");
        Console.WriteLine("Введите действительную часть: ");
        double c1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите действительную часть: ");
        double c2 = Convert.ToDouble(Console.ReadLine());
        Complex c = new Complex(b1, b2);
        Console.WriteLine(c);

        Console.WriteLine("Введите четвертое комплексное число : ");
        Console.WriteLine("Введите действительную часть: ");
        double d1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите действительную часть: ");
        double d2 = Convert.ToDouble(Console.ReadLine());
        Complex d = new Complex(b1, b2);
        Console.WriteLine(d);

        r = Complex.Pow(a, 1/3);
        R = r - ((b + c) / a) + b * d;
       
        Console.WriteLine("Ответ: "+ R);
    }
    
}
