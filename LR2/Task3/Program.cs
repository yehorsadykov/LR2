using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        Random o = new Random();
        List<int> chisla = new List<int>();

        // Кількість чисел у колекції
        int N = 20; // Можна змінити на потрібну кількість чисел

        // Формуємо колекцію з N випадкових чисел у діапазоні [-20; 20]
        for (int i = 0; i < N; i++) {
            chisla.Add(o.Next(-20, 21)); // Додаємо випадкові числа в діапазоні [-20, 20]
            Console.WriteLine("{0}", chisla[i]);
        }

        // Створюємо два нових списки для однозначних і двозначних чисел
        List<int> oneDigitNumbers = new List<int>();
        List<int> twoDigitNumbers = new List<int>();

        // Проходимо через всі числа в оригінальному списку
        foreach (int number in chisla) {
            // Перевіряємо, чи є число однозначним або двозначним
            if (number >= -9 && number <= 9) {
                oneDigitNumbers.Add(number); // Додаємо однозначні числа в список
            } else if ((number >= -99 && number <= -10) || (number >= 10 && number <= 99)) {
                twoDigitNumbers.Add(number); // Додаємо двозначні числа в список
            }
        }

        // Виводимо однозначні числа
        Console.WriteLine("\nОднозначні числа:");
        foreach (int number in oneDigitNumbers) {
            Console.WriteLine("{0}", number);
        }

        // Виводимо двозначні числа
        Console.WriteLine("\nДвозначні числа:");
        foreach (int number in twoDigitNumbers) {
            Console.WriteLine("{0}", number);
        }
    }
}
