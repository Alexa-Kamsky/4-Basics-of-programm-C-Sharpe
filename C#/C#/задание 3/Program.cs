using System;

Random randomMethodForGeneratingNumbers = new Random();
int theNumberGeneratedByTheProgramUsingTheRandomMethod = randomMethodForGeneratingNumbers.Next(1, 11);
int theNumberEnteredByTheUserThatHeThinksTheProgramHasGuessed;

try
{
    while (true)
    {
        Console.WriteLine("Введите ваше число: ");
        theNumberEnteredByTheUserThatHeThinksTheProgramHasGuessed = Convert.ToInt32(Console.ReadLine());
        // "\n" было просто для красивой (на мой взгляд) истории в терминале..
        if (theNumberEnteredByTheUserThatHeThinksTheProgramHasGuessed < theNumberGeneratedByTheProgramUsingTheRandomMethod)
        {
            Console.WriteLine("Bigger.");
        }
        else if (theNumberEnteredByTheUserThatHeThinksTheProgramHasGuessed > theNumberEnteredByTheUserThatHeThinksTheProgramHasGuessed)
        {
            Console.WriteLine("Smaller.");
        }
        else //(YourNum == theNumberGeneratedByTheProgramUsingTheRandomMethod)
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