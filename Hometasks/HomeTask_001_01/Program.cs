/* Задача 2: Напишите программу, 
которая на вход принимает два числа 
и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

int a1 = 5;
int b1 = 7;

/* 
 */

{
    int result1 = a1 - b1;
    if (result1 > 0)
    {
        Console.WriteLine("max = a1");
        Console.WriteLine("min = b1");
    }
    else
    {
        Console.WriteLine("min = a1");
        Console.WriteLine("max = b1");
    }
}

int a2 = 2;
int b2 = 10;

{
    int result1 = a2 - b2;
    if (result1 > 0)
    {
        Console.WriteLine("max = a2");
        Console.WriteLine("min = b2");
    }
    else
    {
        Console.WriteLine("min = a2");
        Console.WriteLine("max = b2");
    }
}

int a3 = -9;
int b3 = -3;

{
    int result1 = a3 - b3;
    if (result1 > 0)
    {
        Console.WriteLine("max = a3");
        Console.WriteLine("min = b3");
    }
    else
    {
        Console.WriteLine("min = a3");
        Console.WriteLine("max = b3");
    }
}

/* */