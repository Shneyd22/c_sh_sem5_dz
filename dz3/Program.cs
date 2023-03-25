// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Введите количество элементов массива");
int size = Convert.ToInt32 (Console.ReadLine());
float[] array = new float[size];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Разница между макс. и мин. числами массива: {FindMax(array) - FindMin(array)}");




void FillArray(float[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}


void PrintArray(float[] array)
{
    foreach (float item in array)
        Console.Write($"{item} ");
    Console.WriteLine();
}


float FindMax(float[] array)
{
    float max = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
return max;
}


float FindMin(float[] array)
{
    float min = 100;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
return min;
}