int Max( int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

Console.WriteLine("Введите 9 чисел: ");
int num1 = new Random().Next(1,100);
int num2 = new Random().Next(1,100);
int num3 = new Random().Next(1,100);
int num4 = new Random().Next(1,100);
int num5 = new Random().Next(1,100);
int num6 = new Random().Next(1,100);
int num7 = new Random().Next(1,100);
int num8 = new Random().Next(1,100);
int num9 = new Random().Next(1,100);

// int max1 = Max(num1,num2,num3);
// int max2 = Max(num4,num5,num6);
// int max3 = Max(num7,num8,num9);
int max = Max(Max(num1,num2,num3), Max(num4,num5,num6), Max(num7,num8,num9)); 

Console.WriteLine(max);