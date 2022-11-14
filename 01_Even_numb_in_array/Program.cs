// Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных 
// чисел в массиве.

void FillArray(int[] array, int minValue = 100, int maxValue = 999)        // функция, где дается какой-то масив, а его элементы переписываются рандомайзером
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
}

void PrintArray(int[] array)            // функция печати массива через foreach
{
    foreach (var item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

int GetQuantityEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}




Console.Clear();
int length = 10;
int[] massive = new int[length];
FillArray(massive);
PrintArray(massive);
int quantityEvenNumbers = GetQuantityEvenNumbers(massive);
Console.WriteLine($"количество чётных чисел в массиве: {quantityEvenNumbers}");