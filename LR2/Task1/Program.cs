using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        Random o = new Random();
        List<int> chisla = new List<int>();

        // Формуємо колекцію з N випадкових чисел (у цьому випадку 10)
        for (int i = 0; i < 10; i++) {
            chisla.Add(o.Next(15, 56)); // додаємо числа в інтервалі [15; 55]
            Console.WriteLine("{0}", chisla[i]);
        }

        // Шукаємо останнє число, що кратне 3 і закінчується на 5
        for (int i = chisla.Count - 1; i >= 0; i--) {
            if (chisla[i] % 3 == 0 && chisla[i] % 10 == 5) {
                chisla.RemoveAt(i); // видаляємо це число
                break; // виходимо з циклу після видалення
            }
        }

        Console.WriteLine("\nПісля видалення:");
        // Виводимо колекцію після видалення
        for (int i = 0; i < chisla.Count; i++) {
            Console.WriteLine("{0}", chisla[i]);
        }
    }
}
