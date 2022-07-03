// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
using static System.Console;
Clear();

Write("Введите размер матрицы через пробел: ");
string[] sizeS = ReadLine(). Split(' ',StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(sizeS[0]);
int columns = int.Parse(sizeS[1]);
int[,] ar = GetrandomArray(rows, columns);
PrintArray(ar);
WriteLine();

for (int j = 0; j < ar.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        sum += ar[i, j];
    }
    Write($"{ sum / ar.GetLength(0):F1}; ");
}
int[,] GetrandomArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for(int i = 0; i < result.GetLength(0); i++) 
    {
        for(int j = 0; j < result.GetLength(1); j++) 
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++) 
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}

