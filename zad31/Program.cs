// // Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// // Найдите сумму отрицательных и положительных элементов массива.
// // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] FillArray(int size, int leftRange, int rightRange)
// {
//     int[] tempArray = new int[size];
//     Random rand = new Random();

//     for (int i = 0; i < tempArray.Length; i++)
//     {
//         tempArray[i] = rand.Next(leftRange, rightRange + 1);
//     }
//     return tempArray;
// }

// void PrintArray(int[] arrayForPrint)
// {
//     System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
// }

// void FindSumPositiveAndNegative(int[] tempArray, out int sumP, out int sumN)
// {
//     sumP = 0;
//     sumN = 0;
//     for (int i = 0; i < tempArray.Length; i++)
//     {
//         if (tempArray[i] > 0)
//         {
//             sumP += tempArray[i]; // sumPositive = sumPositive + array[i]
// //         }
// //         else
// //         {
// //             sumN += tempArray[i];
// //         }
// //     }
// // }
// // // ---------------------------------------------------------------------------

// // int[] array = FillArray(12, -9, 9);
// // PrintArray(array);
// // FindSumPositiveAndNegative(array, out int sumPositive, out int sumNegative);

// // System.Console.WriteLine($"Сумма положительных элементов массива: {sumPositive}");
// // System.Console.WriteLine($"Сумма отрицательных элементов массива: {sumNegative}");

// // Задача 32: Напишите программу замена элементов массива: положительные элементы замените 
// // на соответствующие отрицательные, и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2]

// // ==============================================
// // // Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// // // [-4, -8, 8, 2] -> [4, 8, -8, -2]


// // int[] FillArray(int size, int leftRange, int rightRange)
// // {
// //     int[] tempArray = new int[size];
// //     Random rand = new Random();

// //     for (int i = 0; i < tempArray.Length; i++)
// //     {
// //         tempArray[i] = rand.Next(leftRange, rightRange + 1);
// //     }
// //     return tempArray;
// // }

// // void Convert(int[] tempArray)
// // {
// //     for (int index = 0; index < tempArray.Length; index++)
// //     {
// //         tempArray[index] *= -1;
// //     }
// // }

// // void PrintArray(int[] arrayForPrint)
// // {
// //     System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
// // }
// // //+|+|+|+|+|+|+|+|+|+|+|+|  


// // int [] array = FillArray(11, -15, 15);
// // PrintArray(array);
// // Convert(array);
// // PrintArray(array);

// // ==============================================
// // Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// // 4; массив [6, 7, 19, 345, 3] -> нет
// // -3; массив [6, 7, 19, 345, -3] -> да

// int[] FillArray(int size, int leftRange, int rightRange)
// {
//     int[] tempArray = new int[size];
//     Random rand = new Random();

//     for (int i = 0; i < tempArray.Length; i++)
//     {
//         tempArray[i] = rand.Next(leftRange, rightRange + 1);
//     }
//     return tempArray;
// }
// void PrintArray(int[] arrayForPrint)
// {
//     System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
// }

// int ReadInt(string text)
// {
//     System.Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// bool FindNumber(int[] array, int number)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//         {
//             return true;
//         }
//     }
//     return false;
// }

// int[] array = FillArray(12, 1, 10);
// PrintArray(array);
// int number = ReadInt("Введите искомое число: ");
// bool find = FindNumber(array, number);
// if (find)
// {
//     System.Console.WriteLine("Да!");
// }
// else
// {
//     System.Console.WriteLine("Нет!");
// }

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// // [6 7 3 6] -> 36 21

// int[] FillArray(int count = 10, int leftRange = -9, int rightRange = 9)
// {
//     Random rand = new Random();
//     int[] tempArray = new int[count];
//     for (int i = 0; i < tempArray.Length; i++)
//         tempArray[i] = rand.Next(leftRange, rightRange + 1);
//     return tempArray;
// }

// void PrintArray(int[] tempArray)
// {
//     Console.WriteLine("[" + string.Join(", ", tempArray) + "]");
// }

// int[] FirstAndLast(int[] tempArray)
// {
//     int[] newArray = new int[tempArray.Length / 2 + tempArray.Length % 2];
//     for (int i = 0; i < tempArray.Length / 2; i++)
//         newArray[i] = tempArray[i] * tempArray[tempArray.Length - i - 1];
//     if (newArray.Length % 2 != 0)
//         newArray[newArray.Length - 1] = tempArray[tempArray.Length / 2];
//     return newArray;
// }

// int[] array = FillArray(5);
// PrintArray(array);
// PrintArray(FirstAndLast(array));

// Random rand = new Random();
// double number = Math.Round(rand.Next(0,10) + rand.NextDouble(), 3);
// System.Console.WriteLine(number);