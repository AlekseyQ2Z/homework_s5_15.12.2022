// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}

int CountingEvenNumbers(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i] % 2 == 0)
        {
            counter++;
        }
    }
    return counter;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.Write(" -> " + CountingEvenNumbers(array));