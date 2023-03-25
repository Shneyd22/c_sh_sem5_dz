// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите количество элементов массива");
int size = Convert.ToInt32 (Console.ReadLine());
int[] array = new int[size];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Сумма чисел с нечетными позициями: {PosElemSum(array)}");




void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
}


void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    Console.WriteLine();
}


int PosElemSum(int[] array)
{
    int sum = 0; 
    for(int index = 0; index < array.Length; index++)
        if (index%2 != 0) sum = sum + array[index];
    return sum;
}