﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using System;
using static System.Console;
Clear();

Write("Введите размер матрицы через пробел: ");
string[] sizeS = ReadLine(). Split(' ',StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(sizeS[0]);
int columns = int.Parse(sizeS[1]);
double[,] ar = GetrandomArray(rows, columns);
PrintArray(ar);
WriteLine();

double[,] GetrandomArray(int rows, int columns)
{
    double[,] result = new double[rows, columns];
    for(int i = 0; i < result.GetLength(0); i++) 
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().NextDouble() * 10;
        }
    }
    return result;
}
void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++) 
        {
            Write($"{array[i, j]:F1} ");
        }
        WriteLine();
    }
}

