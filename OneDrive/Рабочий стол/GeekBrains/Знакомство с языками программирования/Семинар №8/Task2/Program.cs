//Задача 55: Задайте двумерный массив. Напишите программу,
//которая заменяет строки на столбцы. В случае, если это
//невозможно, программа должна вывести сообщение для
//пользователя.

int matrixRows = 4;
int matrixColumns = 4;
int minValueRnd = 1;
int maxValueRnd = 11;
int[,] matrixRnd = CreateMatrix(matrixRows, matrixColumns, minValueRnd, maxValueRnd);
PrintMatrix(matrixRnd);
if (matrixRows == matrixColumns)
{
    ChangeRowColumnsMatrix(matrixRnd);
    Console.WriteLine();
    //int[,] newMatrix = ChangeRowColumnsMatrix(matrixRnd);
    //PrintMatrix(newMatrix);
    PrintMatrix(matrixRnd);
}
else Console.WriteLine("Количество столбцов не равно количеству строк");

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

void ChangeRowColumnsMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}

/*int[,] ChangeRowColumnsMatrix(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newMatrix[i, j] = matrix[j, i];
        }
    }
    return newMatrix;
}
*/