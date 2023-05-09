// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB * numberB || numberB == numberA * numberA )
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}
