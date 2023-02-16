// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] GenerateArray(int size, int leftRange, int rightRange)
{
    double[] array = new double[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.Next(leftRange, rightRange) + rand.NextDouble(), 3);
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[ " + string.Join(", ", array) + "]");
}

double findMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
double findMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double[] myArray = GenerateArray(9, 1, 10);
PrintArray(myArray);
double max = findMax(myArray);
double min = findMin(myArray);
System.Console.WriteLine($"Максимальное число массива {max}");
System.Console.WriteLine($"Минимальное число массива {min}");
System.Console.WriteLine($"Разница между максимальным и минимальным числом массива равна {max - min}");