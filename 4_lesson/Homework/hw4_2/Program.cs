// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void Print(int[] array)
{
    int n = array.Length;
for (int i = 0; i < n; i++)
{
Console.Write($"{array[i]} ");
}
}

int[] Massiv(int n)
{
int[] array = new int[n];
for (int i = 0; i < n; i++)
array[i] = new Random().Next(1,100);
return array;
}

Console.WriteLine("Введите количество элементов массива :");
int[] array1 = Massiv(int.Parse(Console.ReadLine()));
Console.WriteLine("Массив :");
Print(array1);
