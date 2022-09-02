/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] MatrixMultiplic(int[,] arrayOne, int[,] arrayTwo)
{
    int[,] arrayResult = new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)];

    for(int i = 0; i < arrayResult.GetLength(0); i++)
    {
        for(int j = 0; j < arrayResult.GetLength(1); j++)
        {
            for(int k = 0; k < arrayOne.GetLength(1); k++)
            {arrayResult[i,j] += arrayOne[i,k] * arrayTwo[k, j];}
        }
    }

    return arrayResult;
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

int[,] newArray1 = FillArray();
PrintArray(newArray1);
Console.WriteLine();

int[,] newArray2 = FillArray();
PrintArray(newArray2);
Console.WriteLine();

int[,] newArrayResult = MatrixMultiplic(newArray1, newArray2);
PrintArray(newArrayResult);