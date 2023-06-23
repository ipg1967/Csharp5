// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// БУДЕМ СЧИТАТЬ нечетными элементы по нумерации массива - 1, 3 и тд. То есть второй четвертый ...
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

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

int FindSumOdd(int[] tempArray)
{
    int N = 0;
    for (int i = 1; i < tempArray.Length; i = i + 2)
    {

        N = N + tempArray[i];

    }
    return N;
}

// ---------------------------------------------------------------------------

int[] array = FillArray(ReadInt("Введите длину массива:  "), -99, 99);

if (array.Length == 1)
{
    System.Console.WriteLine("В массиве нет нечетных элементов");
}
else
{
    PrintArray(array);
    System.Console.WriteLine($"Сумма нечетных элементов массива равна :  {FindSumOdd(array)}");
}
