Random o = new Random();
List<int> chisla = new List<int>();

for (int i = 0; i < 10; i++) {
   chisla.Add(o.Next(1, 20));
   Console.WriteLine("{0}", chisla[i]);
}

Console.WriteLine();

for (int i = chisla.Count - 1; i >= 0; i--) {
   if (i % 2 == 0) {
      chisla.RemoveAt(i);
   }
}

for (int i = 0; i < chisla.Count; i++) {
   Console.WriteLine("{0}", chisla[i]);
}