// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
Console.Clear();
Console.Write("Введите трехзначное число: ");

int number = Convert.ToInt32(Console.ReadLine());
int hundreds = number / 100;//количество сотен
int ten = (number % 100) / 10;//десятки
int units = (number % 100) % 10;//единицы
Console.WriteLine("Количество сотен: " + hundreds);
Console.WriteLine("Количество десятков: " + ten);
Console.WriteLine("Количество единиц: " + units);
Console.WriteLine("Вторая цифра числа " + number + " равна " + ten);

