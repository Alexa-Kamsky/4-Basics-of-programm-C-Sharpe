using System;
using System.ComponentModel.Design;
using System.Linq;
//using System.ComponentModel.Design; ? wt lib?

//Количество выполненых условий:
byte ComplitedTaks = 0;

Console.WriteLine("Правила для создания пароля:\n\n1. Ваш пароль должен состоять из не меньше 8 символов.\n2. Ваш пароль должен содержать хотя бы одну цифру.\n3. Ваш пароль должен содержать хотя бы одну заглавную букву.\n4. Ваш пароль должен содержать хотя бы один специальный символ (!@#$%^&*).\n\n\n");
Console.WriteLine("Введите ваш пароль:\n");

string UserPassword = Console.ReadLine();

//ПРОВЕРКА ТРЕБОВАНИЙ:

//Проверка на длину пароля:
char length = Convert.ToChar(UserPassword.Length);

    if (length < 8)
        {
            Console.WriteLine("\nОШИБКА_1 | Ваш пароль меньше, чем 8 символов! Выполнено условий: " + ComplitedTaks + "/4");
        } 
    
    else
        {
            ComplitedTaks++;
        }

//Проверка на наличие цифр
char[] FindNums = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

bool IsNums = UserPassword.Any(с => FindNums.Contains(с));

    if (IsNums)
        {
            ComplitedTaks++;
        }
    
    else
        {
            Console.WriteLine("ОШИБКА_2 | Ваш пароль не содержит цифр! Выполнено условий: " + ComplitedTaks + "/4");
        }


//Проверка на заглавную букву

bool hasLetter = UserPassword.Any(c => char.IsLetter(c));
bool hasUpper = UserPassword.Any(c => char.IsUpper(c));

    if (hasLetter)
        {
            if (hasUpper)
                {
                    ComplitedTaks++;
                }

            else
                {
                    Console.WriteLine("ОШИБКА_3 | Ваш пароль не содержит ни одной заглавной буквы. " + ComplitedTaks + "/4");
                }
        }

    else
        {
            Console.WriteLine("ОШИБКА_3 | Ваш пароль не содержит ни одной заглавной буквы. " + ComplitedTaks + "/4");
        }


//Проверка на наличие спец.симфолов

char[] hasSpecSymbols = new char[] { '!', '@', '#', '$', '%', '^', '&', '*' };

bool IsSymbols = UserPassword.Any(c => hasSpecSymbols.Contains(c));

    if (IsSymbols)
        {
            ComplitedTaks++;
        }

    else
        {
            Console.WriteLine("ОШИБКА_4 | Ваш пароль не содержит ни олного специального символа. " + ComplitedTaks + "/4");
        }


//ну а что, зря что-ли ComplitedTaks делала?
if (ComplitedTaks == 4)
        {
            Console.WriteLine("Пароль установлен!");
        } 

    else
        {
            Console.WriteLine("\n\n\nПеречитайте условия для создания пароля и попробуйте ещё раз!");
        }