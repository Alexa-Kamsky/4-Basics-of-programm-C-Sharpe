Console.WriteLine("Эта программа считает сумму введенных Вами чисел. Она завершиться сразу же, как только Вы введете '0', '-0', '+0' или что-то, помимо числа.");
try
{
    int summ = 0;
    int num = Convert.ToInt32(Console.ReadLine());
    while (num != 0 || num != -0 || num != +0)
    {
        int NEWsumm = summ + num;
        Console.WriteLine($"{summ} + {num} = {NEWsumm}");
        summ += num;
        num = Convert.ToInt32(Console.ReadLine());
        NEWsumm += num;
    }
}
catch (FormatException ex)
{
    Console.WriteLine($"Вы ввели не тот формат ({ex.Message})! Необходимо ввести число!");
}