
using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose task:");
        int task = int.Parse(Console.ReadLine());

        switch (task)
        {
            case 1: task1(); break;
            case 2: task2(); break;
            case 3: task3(); break;
            case 4: task4(); break;
            case 5: task5(); break;
            case 6: task6(); break;
            default: Console.WriteLine("Nema"); break;
        }
    }
    static void task1()
    {
        Console.WriteLine("Task1 !");
        Console.Write("a= ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b=");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c=");
        int c = int.Parse(Console.ReadLine());
        Console.Write("d=");
        int d = int.Parse(Console.ReadLine());
        double s = Math.Sqrt(Math.Pow(b-a, 2)+Math.Pow(d-c, 2));
        Console.WriteLine("s="+s);

    }


    static void task2()
    {
        Console.WriteLine("Task2 !");
        Console.WriteLine("Number:");
        int Number = int.Parse(Console.ReadLine());
        if (Number % 2 != 0)
        {
            Console.WriteLine("Ne Parne");

        }
        else
        {
            Console.WriteLine("Parne");
        }

    }


    static void task3()
    {
        Console.WriteLine("Task3 !");
        Console.WriteLine("Enter x:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter y:");
        double y = double.Parse(Console.ReadLine());
        double rxy = x*x+y*y;
        if ((rxy>100) | (rxy<25))
        {
            Console.WriteLine("Hi");
        }
        else if ((rxy==100) | (rxy==25))
        {
            Console.WriteLine("На кордонi");
        }
        else
        {
            Console.WriteLine("Так");
        }
        
    }


    static void task4()
    {
        Console.WriteLine("Task4 !");
        Console.WriteLine("Enter m:");
        byte m = byte.Parse(Console.ReadLine());
        switch (m)
        {
            case 1: Console.WriteLine("Piku"); break;
            case 2: Console.WriteLine("Trefu"); break;
            case 3: Console.WriteLine("Bybnu"); break;
            case 4: Console.WriteLine("Chervu"); break;
            default: Console.WriteLine("Nema takogo"); break;
        }
    }



    static int Mnogennya(int a, int b)
    {
        return a * b;
    }
    static void task5()
    {
        Console.WriteLine("Enter a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter b:");
        int b = int.Parse(Console.ReadLine());
        int result = Mnogennya(a, b);
        Console.WriteLine("result = "+result);
    }


    static void task6()
    {
        Console.WriteLine("Task6 !");
        Console.WriteLine("Enter n :");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter m :");
        int m = int.Parse(Console.ReadLine());
        double result = ((n+1)/(Math.Pow(n, 2)+Math.Pow(m, 2)+1)) - (1.0/((m+1)*(n+1)));
        Console.WriteLine("result = "+result);
    }
}




