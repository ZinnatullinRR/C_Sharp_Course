// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

int SumNechetNum(int[] arr1)
{
    int SumNechet = 0;
    for (int i = 0; i < arr1.Length; i++)
    if (i % 2 == 0)
    {
        SumNechet = SumNechet + arr1[i];
    }
    return SumNechet;
}
Console.WriteLine("Введите количество элементов массива и диапазон");
int[] arr_1 = MassNums(int.Parse(Console.ReadLine()),
int.Parse(Console.ReadLine()),
int.Parse(Console.ReadLine()));
Print(arr_1);
Console.WriteLine("Сумма элементов массива не нечётных позициях");
Console.WriteLine(SumNechetNum(arr_1));
