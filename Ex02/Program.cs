// See https://aka.ms/new-console-template for more information
int[,] array = CreateArray(ReadInt("First"), ReadInt("Second"));

PrintArray(array);

Console.WriteLine();
Console.WriteLine();

if (ChangeRowsAndColumns(ref array))
{
	PrintArray(array);
}
else
{
	Console.WriteLine("Oooops");
}



int ReadInt(string argument)
{
	Console.Write($"Input {argument}:");
	return int.Parse(Console.ReadLine());
}

int[,] CreateArray(int firstLength, int secondLength)
{
	int[,] array = new int[firstLength, secondLength];

	Random random = new Random();

	for (int i = 0; i < firstLength; i++)
	{
		for (int j = 0; j < secondLength; j++)
		{
			array[i, j] = random.Next(1, 11);
		}
	}

	return array;
}

bool ChangeRowsAndColumns(ref int[,] array)
{
	if (array.GetLength(0) != array.GetLength(1))
	{
		return false;
	}

	array = CopyArray(array);

	return true;
}


int[,] CopyArray(int[,] array)
{
	int[,] copiedArray = new int[array.GetLength(1), array.GetLength(0)];

	for (int i = 0; i < array.GetLength(1); i++)
	{
		for (int j = 0; j < array.GetLength(0); j++)
		{
			copiedArray[i, j] = array[j, i];
			//Console.Write($"{copiedArray[i, j]} ");
		}
		//Console.WriteLine();
	}
	Console.WriteLine();
	Console.WriteLine();
	return copiedArray;
}

void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write($"{array[i, j]} ");
		}
		Console.WriteLine();
	}
}
