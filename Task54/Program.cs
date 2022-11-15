// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива. 


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
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void GetNimbersDescendingOrder(int[,] inArray)
{
  
    int temp = 0;

    for (int i = 0; i < inArray.GetLength(0) ; i++)
    {

        for (int j = 0; j < inArray.GetLength(1) - 1; j++)
        {
            for (int p = j+1; p < inArray.GetLength(1); p++)
        {

            if (inArray[i, j] < inArray[i, p])
            {
                temp = inArray[i, j];
                inArray[i, j] = inArray[i, p];
                inArray[i,p] = temp;
            }

        }
        }

        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }

}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

Console.WriteLine();
int[,] array = GetArray(row, columns, 0, 10);
PrintArray(array);
Console.Write("******************* ");
Console.WriteLine();
Console.WriteLine("Элементы по убыванию ");
GetNimbersDescendingOrder(array);