// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.

int temp = 0;

int[,,] GetArray(int m, int n, int l, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, l];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {

                result[i, j, k] = new Random().Next(minValue, maxValue + 1);

                if (result[i, j, k] == temp)
                    result[i, j, k] = result[i, j, k] + 1;

            }
        }
    }
    return result;
}

void PrintArray(int[,,] inArray)
{

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {



                Console.Write($"({i},{j},{k})  ");
                Console.Write($"{inArray[i, j, k]}  |");

            }
            Console.WriteLine();
        }

    }
}


int[] BinArrayInToSingle(int[,,] array)
{
    int[] ChangedArray = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int n = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                ChangedArray[n++] = array[i, j, k];
            }
        }
    }
    return ChangedArray;
}

void CheckArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i + 1; j < array.GetLength(0); j++)
        {
            if (array[i] == array[j])
            {
                temp = array[j];

            }
        }
    }


}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество страниц в массиве: ");
int pages = int.Parse(Console.ReadLine()!);

Console.WriteLine();
int[,,] ThreeDArray = GetArray(row, columns, pages, 10, 40);
int[] arrayCheck = BinArrayInToSingle(ThreeDArray);
CheckArray(arrayCheck);
PrintArray(ThreeDArray);