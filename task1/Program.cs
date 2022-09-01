/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] ArrangeDecrease(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1) - 1; k++) // сортировка выбором
        {
            int min = array[i, 0];
            int y = 0;
            for (int j = 1; j < array.GetLength(1) - k; j++)
            {
                if(min > array[i,j])
                {
                    min = array[i,j];
                    y = j;
                }
            }
            int temp = array[i, array.GetLength(1) - 1 - k];
            array[i, array.GetLength(1) - 1 - k]  = array[i, y];
            array[i, y] = temp;
        }
    }

    return array;
}

int[,] FillArray(int m = 4, int n = 4)
{
    int[,] array = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 11);
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


int[,] newArray = FillArray();
PrintArray(newArray);
Console.WriteLine();
PrintArray(ArrangeDecrease((int[,]) newArray.Clone()));
