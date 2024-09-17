using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        Random o = new Random();
        List<int> chisla = new List<int>();

        // Кількість чисел у колекції
        int N = 10; // Можна змінити на потрібну кількість чисел
        // Число X для вставки
        Console.WriteLine("Введіть число X для вставки: ");
        int X = Convert.ToInt32(Console.ReadLine());

        // Формуємо колекцію з N випадкових чисел у діапазоні [5; 50]
        for (int i = 0; i < N; i++) {
            chisla.Add(o.Next(5, 51)); // Додаємо випадкові числа в діапазоні [5, 50]
            Console.WriteLine("{0}", chisla[i]);
        }

        // Створюємо новий список для збереження результатів
        List<int> result = new List<int>();

        // Проходимо через всі числа в оригінальному списку
        foreach (int number in chisla) {
            // Додаємо число X перед кожним числом, яке кратне своїй останній цифрі
            int lastDigit = number % 10;
            if (lastDigit != 0 && number % lastDigit == 0) {
                result.Add(X);
            }
            result.Add(number);
        }

        // Виводимо новий список
        Console.WriteLine("\nСписок після вставки:");
        foreach (int number in result) {
            Console.WriteLine("{0}", number);
        }
    }
}