// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


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

int[] findResult(int[] array)
{
    int size;
    if (array.Length % 2 == 0)
    {
        size = array.Length / 2;
    }
    else
    {
        size = array.Length / 2 + 1;
    }
    int[] arrResult = new int[size];
    for (int i = 0; i < size; i++)
    {
        arrResult[i] = array[i] * array[array.Length - 1 - i];
    }
    if(array.Length%2!=0)
    {
        arrResult[arrResult.Length-1]=array[size-1];
    }
    return arrResult;
}

int[] myArray = GenerateArray(9, 1, 10);
PrintArray(myArray);
int[] newArr = findResult(myArray);
PrintArray(newArr);
