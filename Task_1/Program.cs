// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве

//void PrintArray(int[] mass)   // Одномерный массив.Функция заполнения массива рандомными 3-хзначными числами и вывода на экран
//{
//    for (int i = 0; i < mass.Length; i++)
//    {
//        mass[i] = new Random().Next(100, 1000);
//    }
//    Console.WriteLine("[{0}]", string.Join(",", mass));
//}

void PrintArray1(int[,] mass)   // Функция заполнения массива рандомными 3-хзначными числами и вывода на экран
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for(int j=0; j < mass.GetLength(1);j++)
        {
        mass[i,j] = new Random().Next(100, 1000);
        Console.Write($"{mass[i,j]} ");
        }
        Console.WriteLine();
    }
}

//void Schet(int[] mass)     // Функция для подсчета количества четных элементов одномерный.
//{
//    int count = 0;
//    for (int i = 0; i < mass.Length; i++)
//    {
//        if (mass[i] % 2 == 0) count = count + 1;
//    }
//    Console.Write($"Количество четных элементов в массиве = {count}");
//}

void Schet1(int[,] mass)     // Функция для подсчета количества четных элементов.
{
    int count = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for(int j=0; j < mass.GetLength(1);j++)
        {
            if (mass[i,j] % 2 == 0) count = count + 1;
        }
    }
    Console.Write($"Количество четных элементов в массиве = {count}");
}
int[,] array = new int[5,5];
//PrintArray(array);
//Schet(array);
PrintArray1(array);
Schet1(array);

