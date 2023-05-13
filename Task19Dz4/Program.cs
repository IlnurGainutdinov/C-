// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// System.Console.WriteLine("Введите пятизначное число: ");
// string number = Console.ReadLine();
// if(number[0] == number[4] && number[1] == number[3])
// {
//     System.Console.WriteLine("Да");
// }
// else
// {
//     System.Console.WriteLine("Нет");
// }


// System.Console.WriteLine("Введите пятизначное число: ");
// string number = Console.ReadLine();

// if(number.Length < 5 || number.Length >5)
// {
//     System.Console.WriteLine("Это не пятизначное число");
// }
// else if(number[0] == number[4] && number[1] == number[3])
// {
//     System.Console.WriteLine("Да");
// }
// else
// {
//     System.Console.WriteLine("Нет");
// }

System.Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int i = 1;
if(number[0] == number[number.Length - 1])
{   
    while(i < number.Length / 2)
    {
        
        if(number[i] == number[number.Length - 1 - i])
        {
            i++;
        }
    }
    System.Console.WriteLine("Да");
}
    
else
{
    System.Console.WriteLine("Нет");
}
