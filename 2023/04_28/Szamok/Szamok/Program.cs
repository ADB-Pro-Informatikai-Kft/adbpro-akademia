using System;
using System.Collections.Generic;

namespace Listak
{
internal class Program
{
    public static void Main(string[] args) {
        List<int> szamok = new List<int>();

        for (int i = 1; i < 6; i++) {
            Console.Write($"{i}. szám: ");
            int szam = int.Parse(Console.ReadLine());
            szamok.Add(szam);
        }

        Console.WriteLine($"A számok összege: { Osszeg(szamok) }");
        Console.WriteLine($"A számok átlaga: { Atlag(szamok)}") ;
        Console.WriteLine($"A legnagyobb szám: { Maximum(szamok) }");
        Console.WriteLine($"A legkisebb szám: { Minimum(szamok) }");
        
        Console.ReadKey();
    }

    static int Osszeg(List<int> lista) {
        int osszeg = 0;
        
        foreach (var elem in lista) {
            osszeg += elem;
        }
        
        return osszeg;
    }
    
    static double Atlag(List<int> lista) {
        return (double)Osszeg(lista) / lista.Count;
    }

    static int Maximum(List<int> lista) {
        int max = lista[0];

        foreach (var elem in lista) {
            if (max < elem) {
                max = elem;
            }
        }

        return max;
    }

    static int Minimum(List<int> lista) {
        int min = lista[0];

        foreach (var elem in lista) {
            if (elem < min) {
                min = elem;
            }
        }

        return min;
    }
}
}
