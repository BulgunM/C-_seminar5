// Задайте массив. 
// Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool FindNumber(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) return true;
    }
    return false;
}

bool FindNumber1(int[] array, int number)
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            result = true;
            break;
        }
    }
    return result;
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

int[] arr = CreateArrayRndInt(5, 1, 59);
PrintArray(arr);

bool findNumber = FindNumber(arr, 5);
Console.WriteLine(findNumber ? "Да" : "Нет");

bool findNumber1 = FindNumber1(arr, 5);
Console.WriteLine(findNumber1 ? "Да" : "Нет");