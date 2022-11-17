// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.;
// a = 25, b = 5 -> да;
// a = 2, b = 10 -> нет;
// a = 9, b = -3 -> да;
// a = -3, b = 9 -> нет;

Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int kvadrat = number2 * number2;
if (kvadrat == number1)
{
    Console.WriteLine("Второе число является корнем первого");
} 
else
{
     Console.WriteLine("Второе число не является корнем первого");
}
