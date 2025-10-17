Console.WriteLine("Введите температуру в градусах Цельсия: ");
string T_C = Console.ReadLine();
double T_Cel = Convert.ToDouble(T_C);
double T_F = ((T_Cel * 1.8) + 32);
Console.WriteLine(T_C + "°C" + " = " + T_F + "°F");
