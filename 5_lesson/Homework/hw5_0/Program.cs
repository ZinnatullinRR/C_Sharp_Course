﻿// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

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

int CountChetNum(int[] arr1)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine("Введите количество элементов массива и диапазон");
int[] arr_1 = MassNums(int.Parse(Console.ReadLine()),
int.Parse(Console.ReadLine()),
int.Parse(Console.ReadLine()));
Print(arr_1);
Console.WriteLine("Количество четных элементов массива");
Console.WriteLine(CountChetNum(arr_1));