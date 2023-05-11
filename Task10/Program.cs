Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int second_digit = number % 100 / 10;
    Console.WriteLine($"{second_digit}");
}
else
{
    System.Console.WriteLine("Это не трехзначное число");
}   
