Console.WriteLine("Эта программа считает сумму введенных Вами чисел. Она завершиться сразу же, как только Вы введете '0', '-0', '+0' или что-то, помимо числа.");
try
{
    int initialAmount = 0;
    int theNumberThatTheUserOutputs = Convert.ToInt32(Console.ReadLine());
    while (theNumberThatTheUserOutputs != 0 || theNumberThatTheUserOutputs != -0 || theNumberThatTheUserOutputs != +0)
    {
        int The_Amount_Increased_By_The_Number_Received_From_Th_User = initialAmount + theNumberThatTheUserOutputs;
        Console.WriteLine($"{initialAmount} + {theNumberThatTheUserOutputs} = {The_Amount_Increased_By_The_Number_Received_From_Th_User}");
        initialAmount += theNumberThatTheUserOutputs;
        theNumberThatTheUserOutputs = Convert.ToInt32(Console.ReadLine());
        The_Amount_Increased_By_The_Number_Received_From_Th_User += theNumberThatTheUserOutputs;
    }
}
catch (FormatException ex)
{
    Console.WriteLine($"Вы ввели не тот формат ({ex.Message})! Необходимо ввести число!");
}