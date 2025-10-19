try
{
    Console.WriteLine("Введите температуру в градусах Цельсия: ");
    string temperatureCelsiaReceivedFromAUser = Console.ReadLine();
    double celsiusTemperatureNumberValue = Convert.ToDouble(temperatureCelsiaReceivedFromAUser);
    double Temperature_Farenheit = (celsiusTemperatureNumberValue * 1.8) + 32;
    Console.WriteLine($"{celsiusTemperatureNumberValue}°C = {Temperature_Farenheit} °F");
}
catch (FormatException ex)
{
    Console.WriteLine($" Вы ввели не тот формат ({ex.Message})! Необходимо ввести число!");
}