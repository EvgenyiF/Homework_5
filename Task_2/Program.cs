// Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
void PrintArray(int[] mass)   // Одномерный массив.Функция заполнения массива рандомными 3-хзначными числами и вывода на экран
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(100, 1000);
    }
    Console.WriteLine("[{0}]", string.Join(",", mass));
}

void Summa(int[] mass)     // Функция для подсчета суммы элементов одномерный.
{
    int summ = 0;
    for(int i=1; i<mass.Length;i=i+2)
    {
        summ = summ + mass[i];
    }
    Console.Write($"Сумма элементов стоящих на нечетных позициях = {summ}");
}

int[] array = new int[20];
PrintArray(array);
Summa(array);
