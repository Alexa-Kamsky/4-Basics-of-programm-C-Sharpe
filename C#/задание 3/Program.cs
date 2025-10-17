using System;

Random NumRand = new Random();
int Num = NumRand.Next(1, 11);
int YourNum;

do
{
    Console.WriteLine("Введите ваше число: ");
    YourNum = Convert.ToInt32(Console.ReadLine());

    if (YourNum < Num)
    {
        Console.WriteLine("Bigger.\n");
    }

    if (YourNum > Num)
    {
        Console.WriteLine("Smaller.\n");
    }

    if (YourNum == Num)
    {
        Console.WriteLine("Got it!\n");
    }
} while (YourNum != Num);
