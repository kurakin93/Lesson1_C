Console.WriteLine("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 100 && a <= 1000)
{
    int b = a % 10;
    Console.WriteLine(b);
}
else
    Console.WriteLine("Число не трехзначное");