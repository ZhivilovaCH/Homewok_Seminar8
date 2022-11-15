// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

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

void CountMinSum(int[,] inArray)
{
    int minSum = 0;
    int maxSum = 0;
    int temp = 0;
    int s = 0;
    int n = 0;
    while (n < row)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {

            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                temp += inArray[n, j];
            }
         
            Console.Write($"{("Сумма строки = " + temp)}\t ");

            if (temp > maxSum)
                maxSum = temp;

            if (minSum == 0)
                minSum = temp;

            if (minSum > temp)
            {
                minSum = temp;
                s = i;

            }

            temp = 0;
            n++;
        }
        s+=1;
        
    }
    Console.WriteLine();
    Console.Write($"{("Строка с наименьшей суммой элементов = "+ s)}\t ");
}


int[,] array = GetArray(row, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
CountMinSum(array);