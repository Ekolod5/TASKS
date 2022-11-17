// Напишите программу, которая будет выдавать название дня недели по заданному номеру.;
// 3 -> среда;
// 5 -> пятница;

Console.Write("Input day number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 == 1)
    Console.WriteLine("Monday");
else
if (number1 == 2)
    Console.WriteLine("Tuesday");
else
if (number1 == 3)
    Console.WriteLine("Wednesday");
else
if (number1 == 4)
    Console.WriteLine("Thursday");
else
if (number1 == 5)
    Console.WriteLine("Friday");
else
if (number1 == 6)
    Console.WriteLine("Saturday");
else
if (number1 == 7)
    Console.WriteLine("Sanday");
else
    Console.WriteLine("Not a day");
