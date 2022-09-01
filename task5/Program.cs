/*
Доп. задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] SpiralNums (int row, int col)
{
    int[,] array = new int[row, col];
    int num = 0;

    for(int y = 0; y < col; y++) // заподняем первую строку
    {
        num++; // числа для заполнения спирали
        array[0, y] = num;      
    }

    // для заполнения матрица спиралью определим чего меньше:строк или столбцов,
    // количество циклов заполнения будет равно меньшему числу
    // если строк меньше или столько же, то циклов будет еще на 1 меньше
    int cyclesNumber = (row < col? row : col)  - (row <= col? 1 : 0);
    
    int i = 0; // координата строк начала закручивания спирали
    int j = col - 1; // координата столбцов начала закручивания спирали

    for(int cycle = 1; cycle <= cyclesNumber; cycle++)
    {
        for(int temp = 0; temp < row - cycle; temp++) // проход по строкам
        {
            num++; //берем следующее число
            if(cycle % 2 == 1) // если цикл не четный, то движемся вниз
            {
                i++;
                array[i, j] = num;
            }
            else // иначе вверх
            {
                i--;
                array[i, j] = num;
            }
        }
        
        for(int temp = 0; temp < col - cycle; temp++) // проход по столбцам
        {
            num++; //берем следующее число
            if(cycle % 2 == 1) // если цикл не четный, то движемся влево
            {
                j--;
                array[i, j] = num;
            }
            else // иначе вправо
            {
                j++;
                array[i, j] = num;
            }
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

int GetNumber()
{
    Console.WriteLine("Введите число");
    string text = Console.ReadLine();

    string[] sentence ={"введите именно число", 
                        "Число! это дожно быть число!!! \nпопробуй еще раз", 
                        "Это не закончится до тех пор, пока не будет введено число.", 
                        "ты не знаешь что такое число? 1, 2, 5, 10... \nПопробуй еще раз. Я верю -ты сможешь!", 
                        "Это не число! Не ошибись! Ни чего кроме числа! одного числа!"};

    if(!int.TryParse(text, out int number))
    {
        Console.WriteLine(sentence[new Random().Next(0, 5)]);
        return GetNumber();
    }

    return number;
}

Console.WriteLine("Задайте размер спиральной матрицы m на n, введите целые числа поочередно");
int[,] myArray = SpiralNums(GetNumber(), GetNumber());
PrintArray(myArray);