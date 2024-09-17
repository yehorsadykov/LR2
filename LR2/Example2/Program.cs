using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<int> chisla = new List<int>() { 3, 8, 1, 5, 12, 7 };

        int mx = chisla[0];
        int nmx = 0; 

        for (int i = 1; i < chisla.Count; i++) {
            if (chisla[i] > mx) {
                mx = chisla[i]; 
                nmx = i; 
            }
        }

      Console.WriteLine("\n{0} {1}", mx, nmx);
   }
}