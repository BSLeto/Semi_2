// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();

Console.WriteLine("Введите число обозначающее день недели");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber == 6 || dayNumber == 7) Console.WriteLine("Выходной день недели");
else if (dayNumber > 0 && dayNumber < 6) Console.WriteLine("Рабочий день недели");
else Console.WriteLine("Такого дня недели нет");

