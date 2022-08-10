Console.Clear();
// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

// int number = new Random().Next(10, 100);
// Console.WriteLine("Случайное число: " + number);

// int firstDigit = number / 10;
// // Console.WriteLine("Первая цифра: " + firstDigit);
// int secondDigit = number % 10;
// // Console.WriteLine("Вторая цифра: " + secondDigit);
// int max = firstDigit;
// if (max < secondDigit) max = secondDigit;

// Console.WriteLine($"Максимальное цифра в числе {number} - это {max} "); //Интерполяция

// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
// int number = new Random().Next(100, 1000);
// Console.WriteLine("Случайное число: " + number);

// int firstDigit = number / 100;
// Console.WriteLine("Первая цифра: " + firstDigit);
// int thirdDigit = number % 10;
// Console.WriteLine("Третья цифра: " + thirdDigit);
// int result = firstDigit * 10 + thirdDigit;
// Console.WriteLine(result);


// 12. Напишите программу, которая будет принимать на вход два числа и выводить,
//  является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.WriteLine("Введите первое число");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// int div = firstNumber % secondNumber;

// if (div == 0) Console.WriteLine("кратно");
// else Console.WriteLine($"Первое число не кратно второму, остаток равен: {div}");

// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да


// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 7 == 0 && number % 23 == 0) Console.WriteLine("Данное число кратно одновременно и 7 и 23");
// else Console.WriteLine("Данное число не кратно 7 и 23 одновременно");

// 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет
Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber*firstNumber == secondNumber || secondNumber*secondNumber== firstNumber) Console.WriteLine($"Да");
else Console.WriteLine($"Нет");
 