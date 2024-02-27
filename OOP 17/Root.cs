using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Базовий абстрактний клас Root
public abstract class Root
{
    protected double X;

    protected virtual void FindRoot() { }
    public virtual string Print() { return $"X = {X}"; }
}


// Похідний клас Square
public class Square : Root
{
    // Коефіцієнти рівняння
    public readonly int a;
    public readonly int b;
    public readonly int c;

    // Конструктор
    public Square(int a, int b, int c = 0)
    {
        if (a == 0)
            throw new InvalidOperationException();

        this.a = a;
        this.b = b;
        this.c = c;

        FindRoot();
    }

    protected override void FindRoot()
    {
        int discriminant = b * b - 4 * a * c;
        if (discriminant < 0)
        {
            throw new Exception();
        }
        else
        {
            double root1 = (double)(-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (double)(-b - Math.Sqrt(discriminant)) / (2 * a);

            X = Math.Max(root1, root2);
        }
    }

    public override string Print()
    {
        return base.Print();
    }
}


// Похідний клас Linear
public class Linear : Root
{
    // Коефіцієнти рівняння
    public readonly int k;
    public readonly int b;

    // Конструктор
    public Linear(int k, int b = 0)
    {
        if (k == 0)
            throw new InvalidOperationException();

        this.k = k;
        this.b = b;

        FindRoot();
    }

    protected override void FindRoot()
    {
        X = (double)-b / k;
    }

    public override string Print()
    {
        return base.Print();
    }
}