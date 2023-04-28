Console.Write("Введите число ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// if(number < 0 )
// {
//     number = -number;
// }
int lastnumber = 0;
if(number > 99 && number < 1000)
{
    lastnumber = number % 10;
    Console.Write($"Последняя цифра числа {number} равна {lastnumber}");
}
else
{
    Console.Write("Это не трёхзначное число");
}