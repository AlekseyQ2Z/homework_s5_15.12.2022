// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
// [3.3 7.76 22 2 78.67] -> 76.67

void FillArrayDouble(double[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(0, 10000)) / 100;
    }
}

void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write(" ]");
}

double Diff(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
        if (max < array[i])
        {
            max = array[i];
        }
    }
    double diff = max - min;
    return diff;
}

double[] array = new double[10];
FillArrayDouble(array);
PrintArray(array);
Console.Write(" -> " + Diff(array));