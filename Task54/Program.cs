//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

    static void SortingRow(int[,] array)
    {
        int max = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {

            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j] > array[i, j + 1])
                {
                    max = array[i, j];
                }
                else
                {
                    max = array[i, j + 1];
                    array[i, j + 1] = array[i, j];
                    array[i, j] = max;
                }
            }
        }
    }

    static void Main(string[] args)
    {
        int[,] matrix = new int[3, 4];

        FillArray(matrix);
        PrintArray(matrix);
        Console.WriteLine();
        SortingRow(matrix);
        SortingRow(matrix);
        SortingRow(matrix);
        PrintArray(matrix);
    }
}
