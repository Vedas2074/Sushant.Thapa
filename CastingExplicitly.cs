using System;


 
 class CastingExplicitly
 {
     static void Main17(string[] args)
     {
        //  double c =9.8;
        //  int d = (int)c;
        // Console.WriteLine(d); // d is 9 losing the .8 part


         long e = 5_00_000_000;
        int f = (int)e;
       Console.WriteLine($"e is {e:N0} and f is {f:N0}");
        e = long.MaxValue;
        f = (int)e;
        Console.WriteLine($"e is {e:N0} and f is {f:N0}");

     }
 }