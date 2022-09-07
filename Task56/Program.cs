// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

using System;

class Programm
{
    static void PrintArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    static void FillArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = new Random().Next(1, 10);
            }
        }
    }

    static int[] SmallerAmount(int[,] array)
    {
        int[] arr = new int[array.GetLength(0)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                arr[i] += array[i, j];
            }
        }
        return arr;
    }

    static void Main(string[] args)
    {
        int[,] matrix = new int[3, 4];

        FillArray(matrix);
        PrintArray(matrix);
        Console.WriteLine();
        int[] arr = SmallerAmount(matrix);
        int SmallRow = arr.Min();
        int index = Array.IndexOf(arr, SmallRow) + 1;
        Console.WriteLine($"Номер строки с наименьшей суммой элементов - {index}");
    }
}