// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

using System;

class Programm
{
    static void PrintMatrix(int[,] matr)
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

    static void FillMatrix(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = new Random().Next(1, 10);
            }
        }
    }

    static int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
    {
        int [,] matrix3 = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
        int j=0;
        int k=0;
        int x=0;
        int y=0;

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int m = 0; m < matrix2.GetLength(1); m++)
            {
                matrix3[x, y] = matrix1[i,j]*matrix2[k,m]+matrix1[i,j+1]*matrix2[k+1,m]+matrix1[i,j+2]*matrix2[k+2,m];
                y++;
            }
            x++;
            y=0;
        }
        return matrix3;
    }

    static void Main(string[] args)
    {
        int[,] matrix1 = new int[4, 3];
        int[,] matrix2 = new int[3, 4];

        FillMatrix(matrix1);
        FillMatrix(matrix2);
        PrintMatrix(matrix1);
        Console.WriteLine();
        PrintMatrix(matrix2);
        Console.WriteLine();
        int[,] matrix3 = MatrixMultiplication(matrix1,matrix2);
        Console.WriteLine("Результат перемножения двух матриц:");
        PrintMatrix(matrix3);

    }
}
