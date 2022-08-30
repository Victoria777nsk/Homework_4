// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число (A): ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень (B): ");
int numberB = Convert.ToInt32(Console.ReadLine());

int i = 1;
int result = 1;

if (numberB > 1) // По условию задачи степень В должна быть натуральным числом, т.е. > 1
{
    while (i <= numberB)
    {
        result *= numberA;
        i++;
    }
    Console.Write($"{numberA} ^ {numberB} = {result}");
}
else
{
    Console.Write($"Ошибка! Число степени ({numberB}) НЕ является натуральным.");
}
