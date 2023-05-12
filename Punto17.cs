using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int numero1 = 10;
        int numero2 = 5;
        double resultadoDivision = Division(numero1, numero2);
        Console.WriteLine("El resultado de la division es: " + resultadoDivision);
    }
    public static double Division(int num1, int num2)
    {
        double resultado = (double)num1 / num2;
        return resultado;
    }

}
