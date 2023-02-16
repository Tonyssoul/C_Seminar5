﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[ " + string.Join(", ", array) + "]");
}

int findResult(int[] array)
{
    int arrResult = 0;
    for (int i = 1; i < array.Length; i=i+2)
    {
        arrResult += array[i];
    }
    return arrResult;
}

int[] myArray = GenerateArray(9, 1, 10);
PrintArray(myArray);
int newArr = findResult(myArray);
System.Console.WriteLine(newArr);