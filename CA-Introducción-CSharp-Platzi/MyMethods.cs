using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Cómo crear tus propios métodos 18/26

    public class MyMethods
{
    public void IntegerAddition(int a, int b)
    {
        int Addition = a + b;
        Console.WriteLine("El resultado de la suma es: " + Addition);
    }

    public int IntegerMultiplication(int a, int b)
    {
        int Multiplication = a * b;
        return Multiplication;
    }

    public double IntegerDivision(int a, int b)
    {
        double Division = (double)a / b;
        return Division;
    }

}
