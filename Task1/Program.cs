/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int[] InitArray(int length)
{
int[] resultArray = new int[length];
Random rnd = new Random();
for (int i = 0; i < resultArray.Length; i++)
{
    resultArray[i] = rnd.Next(100,1000);
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
int CheckValues (int[]array)
{
     int counter = 0;
     for (int i = 0; i < array.Length; i++)
     {
        if(array[i] % 2 == 0)
        counter++;
    }
     return counter;
}
int length = GetNumber("Введите размерность массива");
int[] arr = InitArray(length);
PrintArray(arr);

int count = CheckValues(arr);

Console.WriteLine($"количество чётных чисел в массиве: {count}");
