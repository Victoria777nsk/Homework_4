// Задача 29: Напишите программу, которая задаёт массив из введенного числа и выводит их на экран.
// Пользователь вводит число элементов в массиве, минимальное, и максимальное значения.
// Надо заполнить массив рандоными данными от минимального до максимального значения. 
// И важное уточнение, делать все в методе, который возвращает массив.

Console.Write("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] CreateArray(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

int[] array = CreateArray(n, min, max);
PrintArray(array);

