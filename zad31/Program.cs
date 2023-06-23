/ Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }
    return tempArray;
}

void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

void FindSumPositiveAndNegative(int[] tempArray, out int sumP, out int sumN)
{
    sumP = 0;
    sumN = 0;
    for (int i = 0; i < tempArray.Length; i++)
    {
        if (tempArray[i] > 0)
        {
            sumP += tempArray[i]; // sumPositive = sumPositive + array[i]
        }
        else
        {
            sumN += tempArray[i];
        }
    }
}
// ---------------------------------------------------------------------------

int[] array = FillArray(12, -9, 9);
PrintArray(array);
FindSumPositiveAndNegative(array, out int sumPositive, out int sumNegative);

System.Console.WriteLine($"Сумма положительных элементов массива: {sumPositive}");
System.Console.WriteLine($"Сумма отрицательных элементов массива: {sumNegative}");