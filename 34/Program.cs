// // Задача 34: Задайте массив заполненный 
//    случайными положительными трёхзначными числами. 
//    Напишите программу, которая покажет количество чётных чисел в массиве.
//    [345, 897, 568, 234] -> 2

int[] numbers = new int[3];
Random rmd = new Random();
void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rmd.Next(min, max);
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write((i + 1) + " ");
        Console.WriteLine(array[i] + " ");

    }
    Console.WriteLine();
}

int QuantityPositive(int[] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            quantity = quantity + 1;
        {
            array[i]++;
        }
    }
    return quantity;
}

FillArray(numbers, 100, 1000);
WriteArray(numbers);
Console.WriteLine();

int quantity = QuantityPositive(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");
