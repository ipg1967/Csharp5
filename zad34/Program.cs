// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


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

int FindEven(int[] tempArray)
{
    int N = 0;
    for (int i = 0; i < tempArray.Length; i++)
    {
        if (tempArray[i]%2 == 0)
        {
            N++;
        }
    }
    return N;
}

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
// ---------------------------------------------------------------------------
int[] array = FillArray(ReadInt("Введите длину массива:  "), 100, 999);
PrintArray(array);
System.Console.WriteLine($"Количество четных чисел в массиве равно: {FindEven(array)}");
