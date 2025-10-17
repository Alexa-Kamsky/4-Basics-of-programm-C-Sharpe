int summ = 0;

int num = Convert.ToInt32(Console.ReadLine());

while (num != 0 || num != -0)
{
     summ += num;
     Console.WriteLine(summ);
     num = Convert.ToInt32(Console.ReadLine());   
}
