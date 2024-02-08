//Задание 1. Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
// Пример
// m = 2, n = 3 -> A(m,n) = 29

using System;

class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (n == 0)
            return Ackermann(m - 1, 1);
        else
            return Ackermann(m - 1, Ackermann(m, n - 1));
    }

    static void Main(string[] args)
    {
        int m = 2;
        int n = 3;
        int result = Ackermann(m, n);
        Console.WriteLine($"A({m}, {n}) = {result}");
    }
}

// Задание2. Задайте произвольный массив.
//Выведете его элементы, начиная с конца.
//Использовать рекурсию, не использовать циклы.
//Пример
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

using System;

class Programme
{
    static void PrintArrayReverse(int[] arr, int index)
    {
        if (index < 0)
            return;

        Console.Write(arr[index] + " ");
        PrintArrayReverse(arr, index - 1);
    }

    static void Main(string[] args)
    {
        int[] array = { 1, 2, 5, 0, 10, 34 };
        PrintArrayReverse(array, array.Length - 1);
    }
}