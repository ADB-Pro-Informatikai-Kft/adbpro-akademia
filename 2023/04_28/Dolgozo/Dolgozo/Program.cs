using System;
using System.Collections.Generic;

namespace Dolgozo
{
internal class Program
{
    class Dolgozo
    {
        public string Nev { get; set; }
        public int Kor { get; set; }
        public int Fizetes { get; set; }
    }
    
    public static void Main(string[] args) {
        List<Dolgozo> dolgozok = new List<Dolgozo>();
        
        for (int i = 1; i < 4; i++) {
            Dolgozo dolgozo = new Dolgozo();
            
            Console.Write($"{i}. név: ");
            dolgozo.Nev = Console.ReadLine();
            Console.Write($"{i}. kor: ");
            dolgozo.Kor = int.Parse(Console.ReadLine());
            Console.Write($"{i}. fizetés: ");
            dolgozo.Fizetes = int.Parse(Console.ReadLine());
            
            dolgozok.Add(dolgozo);
        }
        
        Console.WriteLine("--------------------");
        
        Console.WriteLine($"Az átlagéletkor: {AtlagEletkor(dolgozok)}");
        Dolgozo legnagyobbFizetesu = LegnagyobbFizetesuDolgozo(dolgozok);
        Console.WriteLine($"A {legnagyobbFizetesu.Nev} nevű dolgozónak a legnagyobb a fizetése, ami {legnagyobbFizetesu.Fizetes} Ft.");
        Dolgozo legfiatalabb = LegfiatalabbDolgozo(dolgozok);
        Console.WriteLine($"A {legfiatalabb.Kor} éves {legfiatalabb.Nev} a legfiatalabb dolgozó, akinek a fizetése {legfiatalabb.Fizetes} Ft.");

        Console.ReadKey();
    }

    static double AtlagEletkor(List<Dolgozo> lista) {
        int osszeg = 0;
        
        foreach (Dolgozo dolgozo in lista) {
            osszeg += dolgozo.Kor;
        }
        
        return (double)osszeg / lista.Count;
    }

    static Dolgozo LegfiatalabbDolgozo(List<Dolgozo> lista) {
        Dolgozo legfiatalabb = lista[0];
        
        foreach (Dolgozo dolgozo in lista) {
            if (dolgozo.Kor < legfiatalabb.Kor) {
                legfiatalabb = dolgozo;
            }
        }
        
        return legfiatalabb;
    }

    static Dolgozo LegnagyobbFizetesuDolgozo(List<Dolgozo> lista) {
        Dolgozo legnagyobbFizetesu = lista[0];

        foreach (Dolgozo dolgozo in lista) {
            if (dolgozo.Fizetes > legnagyobbFizetesu.Fizetes) {
                legnagyobbFizetesu = dolgozo;
            }
        }

        return legnagyobbFizetesu;
    }
}
}