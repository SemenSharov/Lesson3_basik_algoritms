// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = 9999;
int n2 = 100000;


if (n1 < n && n2 > n)
{
    int firstDigit = n / 10000;
    int secondDigit = n % 10000 / 1000;
    int fourthDigit = n % 10000 % 1000 % 100 / 10;
    int fifthDigit = n % 10000 % 1000 % 100 % 10 / 1;
    if (firstDigit == fifthDigit && secondDigit == fourthDigit)
    {
        Console.WriteLine("Является палиндромом!");
    }
    else
    {
        Console.WriteLine("Неявляется палиндромом!");
    }
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число! ");
}