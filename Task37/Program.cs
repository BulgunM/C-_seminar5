// найти произведение пар чисел в одномерном массиве
// парой считается первый и последний элемент, второй и предпоследний и тд
// результат записать в новом массиве

// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] ArrayMultiplication(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size = size + 1;
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1) newArray[size - 1] = array[size - 1];
    return newArray;
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

int[] arr = CreateArrayRndInt(5, 2, 50);
PrintArray(arr);

int[] newArr = ArrayMultiplication(arr);
PrintArray(newArr);