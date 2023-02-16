// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


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

void changeNegativeAndPositive(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {

        array[i] = -array[i];
    }
}

int[] myArray = GenerateArray(12, -9, 9);
PrintArray(myArray);
changeNegativeAndPositive(myArray);
PrintArray(myArray);