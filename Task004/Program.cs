//Задача 228: Напишите программу,
//которая принимает на вход семь чисел,
//и находит их среднее арифметическое
//1 2 3 4 5 6 7-> 4
//10 20 30 40 50 60 70 -> 40

Console.Clear();
int sevenNumbers = 7;
int[] arr = new int[sevenNumbers];
int summ = 0;

for (int i = 0; i < arr.Length; i++)
{
    Console.Write("Введите число " + (i + 1) + " : ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
    summ += arr[i];
}
Console.WriteLine("Сумма введенных чисел равна: " + summ);
int arithmeticMean = summ / arr.Length;
Console.WriteLine("Среднее арифметическое введенных чисел: " + arithmeticMean);
