﻿//Задача 53: Задайте двумерный массив. Напишите программу,
//которая поменяет местами первую и последнюю строку
//массива.

int matrixRows = 5;
int matrixColumns = 5;
int matrixMinValue = 1;
int matrixMaxValue = 11;
int[,] matrix = CreateMatrix(matrixRows, matrixColumns, matrixMinValue, matrixMaxValue);
PrintMatrix(matrix);
ChangeFirstAndLast(matrix);
Console.WriteLine();
PrintMatrix(matrix);

int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("]");
    }
}

void ChangeFirstAndLast(int[,] matrixForChange)
{
    int firstRow = 0;
    int lastRow = matrixForChange.GetLength(0) - 1;
    for (int i = 0; i < matrixForChange.GetLength(1); i++)
    {
        int temp = matrixForChange[firstRow, i];
        matrixForChange[firstRow, i] = matrixForChange[lastRow, i];
        matrixForChange[lastRow, i] = temp;
    }
}