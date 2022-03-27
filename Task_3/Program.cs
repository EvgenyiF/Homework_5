// Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
void PrintArray(double[] mass)   // Одномерный массив.Функция заполнения массива рандомными 3-хзначными числами и вывода на экран
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = Math.Round(new Random().Next(-1000,1000) + new Random().NextDouble(),2);
    }
    Console.WriteLine("[{0}]", string.Join("; ", mass));
}

void MinMax(double[] mass)
{
    double max = mass[0];
    double min = mass[0];
    for (int i=0; i < mass.Length; i++)
    {
        if (mass[i]>max)
        {
            max = mass[i]; 
        }
        else if (mass[i]< min)
        {
            min = mass[i];
        }
    }
Console.Write($"Разница между максимальным и минимальным элементом массива = {Math.Round(max-min,2)}");
}

double[] array = new double[20];
PrintArray(array);
MinMax(array);