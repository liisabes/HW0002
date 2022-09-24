//Задача 13: Напишите программу,
//которая выводит третью цифру заданного числа
//или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();
Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
string arr = Convert.ToString(number);
Console.WriteLine("Количество цифр в числе: " + arr.Length);

if (arr.Length >= 3)
{
    Console.WriteLine("Третья цифра числа " + number + " равна " + arr[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет!");
}
