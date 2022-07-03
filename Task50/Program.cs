// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System;
using static System.Console;
Clear();

Write("Введите число строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите число столбцов массива: ");
int columns = int.Parse(ReadLine());
int[,] array1 = FillArray(rows, columns);

Write("Введите позицию элемента в массиве через пробел: ");
string[] sizeS = ReadLine(). Split(' ',StringSplitOptions.RemoveEmptyEntries);
int m = int.Parse(sizeS[0]);
int n = int.Parse(sizeS[1]);

PrintArray(array1);
WriteLine();

WriteLine($"Ответ: {FindPosition(array1, m, n)}");
WriteLine();

string FindPosition(int[,] array, int m, int n)
{
    string flag = "В заданном массиве отсутствует такой элемент";
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++) 
        {
            if(i == m && j == n) flag = $"Это элемент {array[i, j]}";
        }
    }
    return flag;
}
int[,] FillArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++) 
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
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


