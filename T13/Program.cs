// Напишите программу, которая будет выдавать название дня недели по заданному номеру.;
// 3 -> среда;
// 5 -> пятница;

Console.WriteLine("Week day!");
string[] Days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
int index = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Today is {Days[index-1]}");
