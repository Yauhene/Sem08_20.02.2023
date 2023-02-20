// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
Console.WriteLine("Hello, World!");
Макар  кому  Все 20:02
Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Макар  кому  Все 20:50
void Task_11()
{
    int[,] array = CreateRandomTwoDimensionIntArray(5, 5);

    Console.WriteLine(PrintTwoDimensionIntArray(array));
    Console.WriteLine(PrintTwoDimensionIntArray(SmallerArray(array)));

    int[,] SmallerArray(int[,] array)
    {
        int min = array[0, 0];
        int indexI = 0;
        int indexJ = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (min > array[i, j])
                {
                    min = array[i, j];
                    indexI = i;
                    indexJ = j;
                }
            }
        }

        Console.WriteLine($"наименьшее значение: {min}, минимальный идекс {indexI}, минимальный идекс {indexJ}");

        int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
        int iXOffset = 0;
        int jYOffset = 0;

        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            if (i == indexI)
            {
                iXOffset = 1;
            }
            for (int j = 0; j < newArray.GetLength(1); j++)
            {
                if (j == indexJ)
                {
                    jYOffset = 1;
                }
                newArray[i,j] = array[i + iXOffset, j + jYOffset];
            }
        }

        return newArray;
    }
}

Task_11();
