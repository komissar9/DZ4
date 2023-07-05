// 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
// Console.Write("Введите возводимое в степень число: ");
// int foundation = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите степень: ");
// int power = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// for (int i = 1; i <= power; i++)
// {
//     result = result*foundation;
// }
// Console.WriteLine($"Число {foundation} в степени {power} = {result}");

// 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int copyNumber = userNumber;
int sumDigital = 0;
while (userNumber > 0)
{
    sumDigital = sumDigital + (userNumber % 10);
    userNumber /= 10;
}
Console.WriteLine($"Сумма цифр в числе {copyNumber} равна {sumDigital}");

// 29. Напишите программу, которая задаёт массив из 8 элементов в диапазоне от 10 до 1000 и выводит их на экран. Или массив из 8 элементов вводится с консоли (каждый элемент вводит человек)