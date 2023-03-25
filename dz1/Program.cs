Console.WriteLine("Введите количество элементов массива");
int size = Convert.ToInt32 (Console.ReadLine());
int[] array = new int[size];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Количество четных чисел в массиве: {PosElemSum(array)}");




void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
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
    int count = 0;
    foreach (int item in array)
    {
        if (item%2 == 0) count++;
    }
    return count;
}