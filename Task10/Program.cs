Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int second_digit = number % 100 / 10;
Console.WriteLine($"{second_digit}");
