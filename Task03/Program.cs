// написать программу, котрая будет выдавать 
// название дня недели по заданному номеру. 
// например:
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите номер дня: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("это Понедельник");
}
else if (number == 2) //добавлен оператор "else if" для оптимизации
{
    Console.WriteLine("Это Вторник");
}
else if (number == 3)
{
    Console.WriteLine("Это Среда");
}
else if (number == 4)
{
    Console.WriteLine("это Четверг");
}
else if (number == 5)
{
    Console.WriteLine("Это Пятница");
}
else if (number == 6)
{
    Console.WriteLine("Это Суббота");
}
else if (number == 7)
{
    Console.WriteLine("Это Воскресенье");
}
else Console.WriteLine("Введено некорректное значение, дней в неделе всего 7! ^_^"); // добавлено исключение для ввода
