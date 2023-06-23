// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[] FillArray(int size, int leftRange, int rightRange)
{
    double[] tempArray = new double[size];
    Random rand = new Random();
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 2);
    }
    return tempArray;
}

void PrintArray(double[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

void FindDeltaMinMax(double[] tempArray, out double minN, out double maxN)
{
    minN = tempArray[0];
    maxN = tempArray[0];
    for (int i = 1; i < tempArray.Length; i++)
    {
        if (tempArray[i] < minN)
        {
            minN = tempArray[i]; // ищем минимум
        }
        if (tempArray[i] > maxN)
        {
            maxN = tempArray[i]; // ищем максимум
        }
    }
}

// ---------------------------------------------------------------------------

double[] array = FillArray(ReadInt("Введите длину массива:  "), 0, 99);
PrintArray(array);
FindDeltaMinMax(array, out double minN, out double maxN);
System.Console.WriteLine($"Разница между максимальным элементом массива {maxN} и минимальным элементом {minN} равна {maxN-minN}");
System.Console.WriteLine();
