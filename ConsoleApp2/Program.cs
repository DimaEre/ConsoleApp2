using System;
using System.Collections.Specialized;

    interface Figur
    {
        double S();
        double P();
        void input();
    }

    class Triangle : Figur
    {
        int a;
        int b;
        int c;
        
        public void input()
        {
            Console.WriteLine("сторона 1:   ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("сторона 2:   ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("сторона 3:   ");
            c = Convert.ToInt32(Console.ReadLine());
        }

        public double S()
        {
            int p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public double P()
        {
            return (a + b + c);
        }
    }
    class Romb : Figur
    {
        int a;
        int b;
        public void input()
        {
            Console.WriteLine("сторона:   ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("висота:   ");
            b = Convert.ToInt32(Console.ReadLine());
        }

        public double P()
        {
            return (4 * a);
        }

        public double S()
        {
            return (a*b);
        }
    }
    class Rectangle : Figur
    {
        int a;
        int b;
        public void input()
        {
            Console.WriteLine("сторона 1:   ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("сторона 2:   ");
            b = Convert.ToInt32(Console.ReadLine());
        }

        public double P()
        {
            return(2*(a+b));
        }

        public double S()
        {
            return(a*b);
        }
    }
    class Trapecia : Figur
    {
        int a;
        int b;
        int c;
        int d;
        int e;
        public void input()
        {
            Console.WriteLine("сторона 1:   ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("сторона 2:   ");
            b = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("сторона 3:   ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("сторона 4:   ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("висота:   ");
            e = Convert.ToInt32(Console.ReadLine());
        }

        public double P()
        {
            return (a + b + c + d);
        }

        public double S()
        {
            return (((a + b) / 2) * e);
        }
    }
    class Circle : Figur
    {
        int a;
        public void input()
        {
            Console.WriteLine("радіус:   ");
            a = Convert.ToInt32(Console.ReadLine());
        }

        public double P()
        {
            return (2 * 3.14 * a);
        }

        public double S()
        {
            return (3.14 * a * a);
        }
    }



class Program
{
    private int input(int a)
    {
        Console.WriteLine("\t\tПлощі та периметри фігур");

        Console.WriteLine("Виберіть фігуру");
        Console.WriteLine();
        Console.WriteLine("1)Трикутник");
        Console.WriteLine("2)Ромб");
        Console.WriteLine("3)Прямокутник");
        Console.WriteLine("4)Трапеція");
        Console.WriteLine("5)Коло");
        while (a < 1 || a > 5) a = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        return a;
    }
    public static void Main()
    {
        int a = 0;

        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        Program program = new Program();
        Figur figur;

        a = program.input(a);

        switch (a)
        {
            case 1:
                figur = new Triangle();
                figur.input();
                Console.WriteLine("Периметр трикутника: " + figur.P());
                Console.WriteLine("Площа трикутника: " + figur.S());
                break;
            case 2:
                figur = new Romb();
                figur.input();
                Console.WriteLine("Периметр ромба: " + figur.P());
                Console.WriteLine("Площа ромба: " + figur.S());
                break;
            case 3:
                figur = new Rectangle();
                figur.input();
                Console.WriteLine("Периметр прямокутника: " + figur.P());
                Console.WriteLine("Площа прямокутника: " + figur.S());
                break;
            case 4:
                figur = new Trapecia();
                figur.input();
                Console.WriteLine("Периметр трапеції: " + figur.P());
                Console.WriteLine("Площа трапеції: " + figur.S());
                break;
            case 5:
                figur = new Circle();
                figur.input();
                Console.WriteLine("Периметр кола: " + figur.P());
                Console.WriteLine("Площа кола: " + figur.S());
                break;
        }
    }
}


