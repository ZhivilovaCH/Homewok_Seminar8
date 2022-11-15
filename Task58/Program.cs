// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplicationOfNumbers(int[,] inArray1, int[,] inArray2)
{

    int temp = 0;
    int m1 = inArray1.GetLength(0);
    int m2 = inArray1.GetLength(1);
    int n1 = inArray2.GetLength(0);
    int n2 = inArray2.GetLength(1);


    int[,] resultArray = new int[m1, n2];

    for (int i = 0; i < inArray1.GetLength(0); i++)
    {
        for (int j = 0; j < inArray2.GetLength(1); j++)
        {
            temp = 0;
            for (int k = 0; k < inArray1.GetLength(1); k++)
            {
                temp += inArray1[i, k] * inArray2[k, j];
            }  
            resultArray[i, j] = temp;
        }
    }
    return resultArray;
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] matrix1 = GetArray(row, columns, 1, 4);
int[,] matrix2 = GetArray(row, columns, 1, 4);

PrintArray(matrix1);
Console.WriteLine("----");
PrintArray(matrix2);
Console.WriteLine("Произведение двух матриц: ");
int[,] matrixArray = MultiplicationOfNumbers(matrix1, matrix2);
PrintArray(matrixArray);