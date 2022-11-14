// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.

void FillArray(double[] array, int minValue = -99, int maxValue = 99)        
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
}

void PrintArray(double[] array)            
{
    foreach (var item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

double GetMaxNumber(double[] array)         // функция нахождения мах числа в массиве
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max  = array[i];
        }
    }
    return max;
}

double GetMinNumber(double[] array)         // функция нахождения min числа в массиве
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min  = array[i];
        }
    }
    return min;
}


Console.Clear();
Console.Write("Введите длину массива: ");
int length = int.Parse(Console.ReadLine() ?? "0"); ;
double[] massive = new double[length];
FillArray(massive);
PrintArray(massive);
double maxNumb = GetMaxNumber(massive);
double minNumb = GetMinNumber(massive);
Console.WriteLine($"Максимальное число в массиве: {maxNumb}");
Console.WriteLine($"Минимальное число в массиве: {minNumb}");