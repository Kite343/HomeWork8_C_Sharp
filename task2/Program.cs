/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int MinSumNumsRow (int[,] array)
{
    int[] sumRow = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {sum += array[i,j];}
        sumRow[i] = sum;
    }

    int minSum = sumRow[0];
    int x = 0;
    for (int i = 1; i < sumRow.Length; i++){
        if(minSum > sumRow[i])
        {
            minSum = sumRow[i];
            x = i;
        }

    }
    return x;   
}

int[,] FillArray(int m = 4, int n = 4)
{
    int[,] array = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(-10, 11);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {Console.Write("{0,4}", array[i, j]);}
        Console.WriteLine();
    }
}

int[,] myArray = FillArray();
PrintArray(myArray);
Console.WriteLine();
Console.WriteLine($"номер строки с наименьшей суммой элементов: {MinSumNumsRow(myArray)} строка");