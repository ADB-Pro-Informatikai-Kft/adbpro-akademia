using System;

namespace Robot
{
internal class Program
{
    public static void Main(string[] args) {
        // 1. feladat
        Console.Write("Kérem a parancsot: ");
        string input = Console.ReadLine();

        // 2. feladat
        int e = 0;
        int n = 0;
        int k = 0;
        int d = 0;

        foreach (var direction in input) {
            if (direction == 'E') {
                e++;
            } else if (direction == 'N') {
                n++;
            } else if (direction == 'K') {
                k++;
            } else if (direction == 'D') {
                d++;
            }
        }
        
        Console.WriteLine("E betűk száma: {0}", e);
        Console.WriteLine("D betűk száma: {0}", d);
        Console.WriteLine("K betűk száma: {0}", k);
        Console.WriteLine("N betűk száma: {0}", n);
        
        // 3. feladat
        int horizontalDiff = e - d;
        int verticalDiff = n - k;
        
        Console.Write("Egy legrövidebb út parancsszava: ");
        
        if (horizontalDiff > 0) {
            for (int i = 0; i < horizontalDiff; i++) {
                Console.Write("E");
            }
        } else {
            for (int i = 0; i < Math.Abs(horizontalDiff); i++) {
                Console.Write("D");
            }
        }
        
        if (verticalDiff > 0) {
            for (int i = 0; i < verticalDiff; i++) {
                Console.Write("N");
            }
        } else {
            for (int i = 0; i < Math.Abs(verticalDiff); i++) {
                Console.Write("D");
            }
        }

        Console.WriteLine();
        Console.ReadKey();
    }
}
}