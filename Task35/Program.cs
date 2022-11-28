// создать одномерный массив из 123 элементов
// найти количество элементов массива, значения которых лежат в отрезке [10,99]

// пример для массива из 5 элементов
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max - 1);
    }
    return array;
}

int FindNumber(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 10 && array[i] < 99) sum++;
    }
    return sum;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine("]");
}

int[] arr = CreateArrayRndInt(5, 1, 200);
PrintArray(arr);
int result = FindNumber(arr);
Console.WriteLine($"Количество элементов в массиве - > {result}");