/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

int[] InitArray(int length)
{
int[] resultArray = new int[length];
Random rnd = new Random();
for (int i = 0; i < resultArray.Length; i++)
{
    resultArray[i] = rnd.Next(1,100);
}
return resultArray;
}

void PrintArray (int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
        Console.WriteLine();
}
// получение числа с консоли
int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result; 
} 
// получение минимального значения
int Min (int[]array)
{
    int min = array [0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        min = array [i];
    }
    return min;
}
// получение максимального значения
int Max (int[] array)
{
    int max = array [0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        max = array [i];
    }
    return max;
}

int length = GetNumber("Введите размерность массива");
int[] arr = InitArray(length);
PrintArray(arr);
int min = Min(arr);
int max = Max(arr);

Console.WriteLine($"разница между максимальным и минимальным элементов массива: {max-min}");
