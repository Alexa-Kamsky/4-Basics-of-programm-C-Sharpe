using System;
using System.ComponentModel.Design;
using System.Linq;

//Количество выполненных условий:
byte numberOfCompletedTasks = 0;
Console.WriteLine("Правила для создания пароля:\n\n1. Ваш пароль должен состоять из не меньше 8 символов.\n2. Ваш пароль должен содержать хотя бы одну цифру.\n3. Ваш пароль должен содержать хотя бы одну заглавную букву.\n4. Ваш пароль должен содержать хотя бы один специальный символ (!@#$%^&*).\n\n\n");
Console.WriteLine("Введите ваш пароль:\n");
string thePasswordEnteredByTheUser = Console.ReadLine();

//ПРОВЕРКА ТРЕБОВАНИЙ:
//Проверка на длину пароля:
int theLengthOfThePasswordEnteredByTheUser = thePasswordEnteredByTheUser.Length;
if (theLengthOfThePasswordEnteredByTheUser < 8)
{
    Console.WriteLine($"\nОШИБКА_1 | Ваш пароль меньше, чем 8 символов! Выполнено условий: {numberOfCompletedTasks}/4");
}
else
{
    numberOfCompletedTasks++;
}

//Проверка на наличие цифр. А вдруг пользователь введет пароль, состоящий из одних только цифр?
char[] SearchForNumbersInThePasswordEnteredByTheUser = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
bool thePresenceOfNumbersInThePasswordEnteredByTheUser = thePasswordEnteredByTheUser.Any(с => SearchForNumbersInThePasswordEnteredByTheUser.Contains(с));
if (thePresenceOfNumbersInThePasswordEnteredByTheUser)
{
    numberOfCompletedTasks++;
}
else
{
    Console.WriteLine($"ОШИБКА_2 | Ваш пароль не содержит цифр! Выполнено условий: {numberOfCompletedTasks}/4");
}


//Проверка на заглавную букву. А вдруг пользователь введет пароль, состоящий из одних цифр?
bool thePresenceOfALetterInThePasswordEnteredByTheUser = thePasswordEnteredByTheUser.Any(c => char.IsLetter(c));
bool the_Presence_Of_A_Capital_Letter_In_The_Password_Entered_By_The_User = thePasswordEnteredByTheUser.Any(c => char.IsUpper(c));
if (thePresenceOfALetterInThePasswordEnteredByTheUser)
{
    if (thePresenceOfALetterInThePasswordEnteredByTheUser)
    {
        numberOfCompletedTasks++;
    }
    else
    {
        Console.WriteLine($"ОШИБКА_3 | Ваш пароль не содержит ни одной заглавной буквы. {numberOfCompletedTasks}/4");
    }
}
else
{
    Console.WriteLine($"ОШИБКА_3 | Ваш пароль не содержит ни одной заглавной буквы. {numberOfCompletedTasks}/4");
}


//Проверка на наличие спец симфолов
char[] CheckingForSpecialCharactersInThePasswordEnteredByTheUser = new char[] { '!', '@', '#', '$', '%', '^', '&', '*' };
bool thePresenceOfSpecialCharactersInThePasswordEnteredByTheUserls = thePasswordEnteredByTheUser.Any(c => CheckingForSpecialCharactersInThePasswordEnteredByTheUser.Contains(c));
if (thePresenceOfSpecialCharactersInThePasswordEnteredByTheUserls)
{
    numberOfCompletedTasks++;
}
else
{
    Console.WriteLine($"ОШИБКА_4 | Ваш пароль не содержит ни одного специального символа. {numberOfCompletedTasks}/4");
}


//ну а что, зря что-ли ComplitedTaks делала?
if (numberOfCompletedTasks == 4)
{
    Console.WriteLine("Пароль установлен!");
}
else
{
    Console.WriteLine("\n\n\nПеречитайте условия для создания пароля и попробуйте ещё раз!");
}