/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,0,1)
34(0,1,0) 41(0,1,1)
27(1,0,0) 90(1,0,1)
26(1,1,0) 55(1,1,1)
*/

int[,,] FillArray222()
{
    int[] nums = new int[8];
    for (int i = 0; i < 8; i++)
    {
        int num = new Random().Next(10, 100);
        bool flag = true;
        while (flag)
        {
            flag = false;
            foreach (int n in nums)
            {
                if (n == num)
                {
                    flag = true;
                    num = new Random().Next(10, 100);
                }
            }
        }
        nums[i] = num;
    }

    // Console.WriteLine(string.Join(", ", nums));

    int[,,] array = new int[2, 2, 2];
    int x = 0;
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                array[i, j, k] = nums[x];
                x++;
            }
        }
    }

    return array;
}

void PrintArray3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]}({i},{j},{k})  ");

            Console.WriteLine();
        }
    }
}

PrintArray3D(FillArray222());
