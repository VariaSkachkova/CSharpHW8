void Task54()
{
    Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
    int rows = 4;
    int columns = 4;
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    SortByBubble(array);
    Console.WriteLine("Массив с отсортированными по убыванию строками:");
    PrintArray(array);
}

void FillArray(int[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(1, 15);
        }
    }
}
void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void SortByBubble(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {

        for (int j = 0; j < columns; j++)
        {
            int minIndex = j;
            for (int k = j + 1; k < columns; k++)
            {
                if (array[i, k] > array[i, minIndex])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, minIndex];
                    array[i, minIndex] = temp;

                }
            }

        }

    }
}

void Task56()
{
    Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
    int rows = 3;
    int columns = 4;
    int[,] array = new int[rows, columns];
    FillArray(array);
    Console.WriteLine("Вывод массива:");
    PrintArray(array);
    Console.WriteLine("Вывод суммы по строкам:");
    FindRowWithMinSum(array);
}
void FindRowWithMinSum(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int minSum = 0;
    int minSumRow = 0;
    for (int j = 0; j < columns; j++)
    {
        minSum = minSum + array[0, j];

    }
    Console.Write(minSum + "\t");
    for (int i = 1; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum = sum + array[i, j];
        }
        Console.Write(sum + "\t");
        if (minSum > sum)
        {
            minSum = sum;
            minSumRow = i;
        }

    }
    Console.WriteLine();
    Console.WriteLine($"Минимальная сумма элементов – в {minSumRow} строке");
}
Task54();
Console.WriteLine();
Task56();