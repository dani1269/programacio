// See https://aka.ms/new-console-template for more information
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using LanguageExt.ClassInstances.Pred;

Console.WriteLine("Hello, World!");
def suma_digits(num):
    # Convertim el número a una cadena per poder iterar sobre els seus dígits
    num_str = str(num)
    suma = 0

    # Iterem sobre cada dígit i el convertim a enter per sumar-lo
    for Digit in num_str:
        suma += int(digit)
{
    return suma
}

# Demanem a l'usuari que introdueixi un número de 4 dígits
numero = int(input("Introdueix un número enter de 4 dígits: "))

# Calculem la suma dels seus dígits
resultat = suma_digits(numero)

# Mostrem el resultat
print(f"Els dígitos {numero} sumen {resultat}.")