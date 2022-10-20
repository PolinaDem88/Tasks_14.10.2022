/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
int[] InitArray(int length)
{
int[] resultArray = new int[length];
Random rnd = new Random();
for (int i = 0; i < resultArray.Length; i++)
{
    resultArray[i] = rnd.Next(-10,100);
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
    int GetSumm(int[] array)
{
    int summ = 0;
        for (int i = 0; i < array.Length; i++)
    {
        if(i% 2 != 0)
        summ += array[i];
    }
    return summ; 
}
int length = GetNumber("Введите размерность массива");
int[] arr = InitArray(length);
PrintArray(arr);
int summ = GetSumm(arr);
Console.WriteLine($"сумма элементов, стоящих на нечётных позициях {summ}");
