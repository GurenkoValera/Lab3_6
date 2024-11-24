using System;

class Program
{
    static void Main()
    {
        int[] array = { 5, 3, 8, 1, 2, 7, 4, 6 };

        // Итеративное вычисление суммы
        int iterativeSum = sumIterative(array);
        Console.WriteLine($"Итеративная сумма элементов массива: {iterativeSum}");

        // Рекурсивное вычисление суммы
        int recursiveSum = sumRecursive(array, array.Length);
        Console.WriteLine($"Рекурсивная сумма элементов массива: {recursiveSum}");

        // Итеративное вычисление минимального элемента
        int iterativeMin = minIterative(array);
        Console.WriteLine($"Итеративный минимальный элемент массива: {iterativeMin}");

        // Рекурсивное вычисление минимального элемента
        int recursiveMin = minRecursive(array, array.Length);
        Console.WriteLine($"Рекурсивный минимальный элемент массива: {recursiveMin}");
    }

    // Итеративная функция для вычисления суммы
    static int sumIterative(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    // Рекурсивная функция для вычисления суммы
    static int sumRecursive(int[] array, int n)
    {
        if (n <= 0)
            return 0;
        return sumRecursive(array, n - 1) + array[n - 1];
    }

    // Итеративная функция для поиска минимального элемента
    static int minIterative(int[] array)
    {
        int min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }

    // Рекурсивная функция для поиска минимального элемента
    static int minRecursive(int[] array, int n)
    {
        if (n == 1)
            return array[0];
        return Math.Min(array[n - 1], minRecursive(array, n - 1));
    }
}
