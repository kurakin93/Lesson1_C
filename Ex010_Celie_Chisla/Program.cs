﻿Console.WriteLine("Input NUM");
int a = Convert.ToInt32(Console.ReadLine());
int b = -a;

while (b <= a)
{
    Console.WriteLine(","+b);
    b++;
}