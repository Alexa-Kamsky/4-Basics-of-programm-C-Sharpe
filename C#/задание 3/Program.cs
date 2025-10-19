using System;

Random NumRand = new Random();
int Num = NumRand.Next(1, 11);
int YourNum;

try
{
    while (true)
    {
        Console.WriteLine("Введите ваше число: ");
        YourNum = Convert.ToInt32(Console.ReadLine());
        // "\n" было просто для красивой (на мой взгляд) истории в терминале..
        if (YourNum < Num)
        {
            Console.WriteLine("Bigger.");
        }
        else if (YourNum > Num)
        {
            Console.WriteLine("Smaller.");
        }
        else //(YourNum == Num)
        {
            Console.WriteLine("Gotcha!");
            break;
        }
    }
}
catch (FormatException ex)
{
    Console.WriteLine($"Вы ввели не тот формат ({ex.Message})! Необходимо ввести число!\n");    
}