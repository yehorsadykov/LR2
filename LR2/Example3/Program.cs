﻿Random o = new Random();
List<int> chisla = new List<int>();

for (int i = 0; i < 10; i++) {
   chisla.Add(o.Next(1, 10));
   Console.WriteLine("{0}", chisla[i]);
}

Console.WriteLine();

int x = Convert.ToInt32(Console.ReadLine());

chisla.Remove(x);

for (int i = 0; i < chisla.Count; i++) {
   Console.WriteLine("{0}", chisla[i]);
} 