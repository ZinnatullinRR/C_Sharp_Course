//  Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{Math.Round(arr[i], 2)} ");
    Console.WriteLine();
}

double[] MassNums(int size, double from, double to)
{
    double[] arr = new double[size];

    for (int i = 0; i < size; i++)
    {
        Random rnd = new Random();
        arr[i] = rnd.NextDouble() * (to - from) + from;
    }
    return arr;
}

double RaznMaxMin(double[] arr1)
{
    double max = arr1[1];
    double min = arr1[1];
    for (int i = 0; i < arr1.Length; i++)
        if (arr1[i] > max)
        {
            max = arr1[i];

        }
        else if (arr1[i] < min)
        {
            min = arr1[i];
        }
    Console.WriteLine($"{Math.Round(max, 2)}");
    Console.WriteLine($"{Math.Round(min, 2)}");
    return max - min;

}
Console.WriteLine("Введите количество элементов массива и диапазон");
double[] arr_1 = MassNums(int.Parse(Console.ReadLine()),
double.Parse(Console.ReadLine()),
double.Parse(Console.ReadLine()));
Print(arr_1);
Console.WriteLine("Макс и мин элементы массива и разница между ними");
Console.WriteLine($"{Math.Round(RaznMaxMin(arr_1), 2)}");
