//Задача 57: Составить частотный словарь элементов
//двумерного массива. Частотный словарь содержит
//информацию о том, сколько раз встречается элемент
//входных данных.

int matrixRows = 5;
int matrixColumns = 5;
int minValue = 1;
int maxValue = 11;

int[,] firstMatrix = CreateMatrix(matrixRows, matrixColumns, minValue, maxValue);
PrintMatrix(firstMatrix);
Console.WriteLine();
int[] firstArray = NumberDictionary(firstMatrix);
PrintArray(firstArray);
Console.WriteLine();
Array.Sort(firstArray);
PrintArray(firstArray);
Console.WriteLine();
Dictionary(firstArray);

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

int[] NumberDictionary(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[index] = matrix[i, j];
            index++;
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

void Dictionary (int[] array)
{
    int number = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == number) count++;
        else
        {
            Console.WriteLine($"{number} -> {count}");
            number = array[i];
            count = 1;
        }
        
    }
    Console.WriteLine($"{number} -> {count}");
}


/*int[,] Dictionary(int[] array, int column)
{
    int[,] dictionary = new int[column, 2];
    dictionary[0, 0] = array[0];
    dictionary[0, 1] = 1;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == dictionary[i, 0]) dictionary[i, 1]++;
        else
        {
            dictionary[0, 0] = array[0];
        }

    }
    Console.WriteLine($"{number} -> {count}");
    return dictionary;
}
*/