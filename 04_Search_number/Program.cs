// Дан массив чисел. Напишите функцию, которая ищет заданное число в массиве
// и показывает нужный индекс в нем. При отсутствии числа возвращать -1.

void FillArray(int[] array, int minValue = -99, int maxValue = 99)
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

int FindingNumber(int[] array, int numb)            // нахождение индекса нужного числа
{
    int indexNumb = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == numb)
        {
            indexNumb = i;
        }
    }
    return indexNumb;
}


Console.Clear();
Console.Write("Введите длину массива: ");
int length = int.Parse(Console.ReadLine() ?? "0");
int[] massive = new int[length];
FillArray(massive);
PrintArray(massive);
Console.Write("Введите число, которое необходимо найти: ");
int searchNumber = int.Parse(Console.ReadLine() ?? "0");
int indexNumber = FindingNumber(massive, searchNumber);
Console.WriteLine($"Индекс числа {searchNumber}: {indexNumber}");