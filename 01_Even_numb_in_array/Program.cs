// Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных 
// чисел в массиве.

void FillArray(int[] array, int minValue = 100, int maxValue = 999)   
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
}

void PrintArray(int[] array)           
{
    foreach (var item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

int GetQuantityEvenNumbers(int[] array)     // функция кол-ва четных элементов
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
Console.Write("Введите длину массива: ");
int length = int.Parse(Console.ReadLine() ?? "0");;
int[] massive = new int[length];
FillArray(massive);
PrintArray(massive);
int quantityEvenNumbers = GetQuantityEvenNumbers(massive);
Console.WriteLine($"количество чётных чисел в массиве: {quantityEvenNumbers}");