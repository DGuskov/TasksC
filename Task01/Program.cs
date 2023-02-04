// написать программу, которая на вход принимает два числа
// и проверяет, является ли первое число квадратом второго.
// например:
// а = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9 -> нет

Console.WriteLine("введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 * number2 == number1)
{
    Console.WriteLine($"число {number2} является квадратом числа {number1}");
}
else
{
    Console.WriteLine($"число {number2} не является квадратом числа {number1}");
}
