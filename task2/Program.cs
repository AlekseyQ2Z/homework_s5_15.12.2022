// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = new Random().Next(-99, 100);
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

int CountSumOddPosition(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        if ((i + 1) % 2 != 0)
        {
        counter = counter + array[i];
        }
    }
    return counter;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.Write(" -> " + CountSumOddPosition(array));