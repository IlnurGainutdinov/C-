Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C: ");
int numberC = Convert.ToInt32(Console.ReadLine());
if(numberA > numberB && numberA > numberC)
{
    Console.WriteLine($"max = {numberA}");
}
else if(numberB > numberA && numberB > numberC)
{
    Console.WriteLine($"max = {numberB}");
}
else 
{
    Console.WriteLine($"max = {numberC}");
}