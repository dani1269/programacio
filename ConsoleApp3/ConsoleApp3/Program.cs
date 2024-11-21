// See https://aka.ms/new-console-template for more information
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

/// <summary>
/// Programa que demana un número de 4 dígits 
/// i mostra la suma dels seus dígits
/// </summary>
/// <param name="args"></param>
static void Main(string[] args)
{
    int n;
    Console.Write("ENTRA UN NÚMERO DE 4 DÍGITS: ");
    n = Convert.ToInt32(Console.ReadLine());

    //Console.WriteLine($"ELS DIGITS {1234} SUMEN {10}");
    //Console.WriteLine($"ELS DIGITS {1234} SUMEN {1+2+3+4}");
    Console.WriteLine($"ELS DIGITS {n} SUMEN {SumarDigits(n)}");


    Console.ReadLine();

}

/// <summary>
/// Funció que calcula la suma de dígits 
/// d'un enter format per quatre digits
/// </summary>
/// <param name="num">Número enter</param>
/// <returns>Retorna la suma dels quatre digits de "num"</returns>
public static int SumarDigits(int num)
{
    int sum;
    sum = num % 10;
    num = num / 10;

    sum = sum + num % 10;
    num = num / 10;

    sum = sum + num % 10;
    num = num / 10;

    sum = sum + num % 10;
    //num = num / 10;

    return sum;
}
