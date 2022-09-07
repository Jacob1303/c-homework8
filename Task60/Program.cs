// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

using System;

class Programm
{
    static void PrintMatrix(int[,,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                for (int k = 0; k < matr.GetLength(2); k++)
                {
                    Console.Write($"{matr[i, j, k]} ({i},{j},{k}) ");
                }
                Console.WriteLine();
            }
        }
    }

    static void FillMatrix(int[,,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                for (int k = 0; k < matr.GetLength(2); k++)
                {
                    matr[i, j, k] = new Random().Next(11, 99);
                }

            }
        }
    }
    static void Main(string[] args)
    {
        int[,,] matrix = new int[3, 3, 3];
        FillMatrix(matrix);
        PrintMatrix(matrix);
    }
}

