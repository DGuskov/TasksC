﻿// Напишите программу, которая принимает на вход
// трехзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 999 || num >= 100)  // || - для перечисления условий
{
    int lastnum = (num % 10);
    Console.WriteLine("Последнее число - " + lastnum);
}
else
{
    Console.WriteLine("Введенное число не является трехзначным! ");
}