// See https://aka.ms/new-console-template for more information

//=====================================================================================================================
// Функция создает двумерный массив случайных вещественных чисел с заданным размером


double[,] makeArray(int rowNum, int colNum)
{
    double[,] tdArray = new double[rowNum, colNum];
    Random rnd = new Random();
    for (int i = 0; i <= rowNum-1; i++)
    {
        for (int j=0; j <= colNum-1; j++)
        {
            tdArray[i,j] = Math.Round(rnd.NextDouble()+rnd.Next(-20,20), 1); //result[i, j] = Math.Round(rand.NextDouble() + 10, 2);
        }
    }
    return tdArray;
}

double[,] swapRows(double[,] array)
{
    double temp;
    int myRow = array.GetLength(0) - 1;;
    
    for(int j = 0 ; j < array.GetLength(1); j++)
    {
        temp = array[0,j];
        array[0,j] = array[myRow,j];
        array[myRow,j] = temp;
    }
return array;
}

//=====================================================================================================================
// Функция выводит на экран содержимое двумерного массива
void printArray(double[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    string stringRes;
    for (int i = 0; i <= rows-1; i++)
    {
        for (int j = 0; j <= columns-1; j++)
        {
            
            stringRes = string.Format("{0:f2}", arr[i,j]);
            Console.Write(stringRes + "  ");
        }    
        Console.WriteLine();
    }

    for(int i=1; i<3; i++) Console.WriteLine();
   
}

double[,] myArray = makeArray(3, 4);
printArray(myArray);
Console.WriteLine();
myArray = swapRows(myArray);
printArray(myArray);


//Console.WriteLine("Hello, World!");
