int Max( int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

//             0   1   2   3    4   5    6   7    8 
int[] array = {12,123,234,2345,567,5645,578,5674,9879};

// int max1 = Max(num1,num2,num3);
// int max2 = Max(num4,num5,num6);
// int max3 = Max(num7,num8,num9);
int max = Max (Max(array[0], array[1], array[2]), Max(array[3],array[4],array[5]), Max(array[6],array[7], array[8]));


Console.WriteLine(max);