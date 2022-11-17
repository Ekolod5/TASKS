// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.;
// 456 -> 6;
// 782 -> 2;
// 918 -> 8;

Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 100)
    Console.WriteLine("Число не трехзначное");
if (a > 999)
    Console.WriteLine("Число не трехзначное");
if (a < 1000)
    Console.WriteLine("Число трехзначное");
int b = a % 10;
Console.WriteLine("Правая цифра равна " + b);
