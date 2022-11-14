//Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
///a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет

//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница

Console.Write("Введите число: ");
string number = Console.ReadLine();

if(number == "1")
    Console.WriteLine("Понедельник!");
if(number == "2")
    Console.WriteLine("Вторник!");
if(number == "3")
    Console.WriteLine("Среда!");
if(number == "4")
    Console.WriteLine("Четверьг!");
if(number == "5")
    Console.WriteLine("Пятница!");
if(number == "6")
    Console.WriteLine("Суббота!");
if(number == "7")
    Console.WriteLine("Воскресенье!");
if(number < 7 )
    Console.WriteLine("Не является");
