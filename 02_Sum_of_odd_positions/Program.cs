// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

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

int SumOfOddPositions(int[] array)      // сумма элементов, которые находятся на нечётных позицях(поэтому начала с 1 и прибавляла 2)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}


Console.Clear();
Console.Write("Введите длину массива: ");
int length = int.Parse(Console.ReadLine() ?? "0"); ;
int[] massive = new int[length];
FillArray(massive);
PrintArray(massive);
int sum = SumOfOddPositions(massive);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum}");