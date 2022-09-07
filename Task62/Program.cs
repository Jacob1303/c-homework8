// Напишите программу, которая заполнит спирально массив 4 на 4.

using System;

class Programm
{
    static void PrintMatrix(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                string numbmatr = string.Format("{0:d2}", matr[i, j]);
                Console.Write(numbmatr + " ");
            }
            Console.WriteLine();
        }
    }

    static void FillMatrix(int[,] matr)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            int i = 0;
            matr[i, j] = j + 1;
        }
        for (int i = 1; i < matr.GetLength(0); i++)
        {
            int j = matr.GetLength(1) - 1;
            matr[i, j] = matr[i - 1, j] + 1;
        }
        for (int j = matr.GetLength(1) - 2; j >= 0; j--)
        {
            int i = matr.GetLength(0) - 1;
            matr[i, j] = matr[i, j + 1] + 1;
        }
        for (int i = matr.GetLength(0) - 2; i > 0; i--)
        {
            int j = 0;
            matr[i, j] = matr[i + 1, j] + 1;
        }
        for (int j = 1; j < matr.GetLength(1) - 1; j++)
        {
            int i = 1;
            matr[i, j] = matr[i, j - 1] + 1;
        }
        for (int j = matr.GetLength(1) - 2; j > 1; j--)
        {
            int i = matr.GetLength(0) - 2;
            matr[i, j] = matr[i-1, j ] + 1;
        }
        
        matr[2,1] = 16;
    }

    static void Main(string[] args)
    {
        int[,] matrix = new int[4, 4];

        FillMatrix(matrix);
        PrintMatrix(matrix);
    }
}