using System;
using System.Text.RegularExpressions;

//ТЕСТОВЫЙ ТЕКСТ ДЛЯ ПРОВЕРКИ:
// Fshdjdd. Jfjdkmffkj, mfnndfk, mfkmfmk. Bjsdkdjk!!! JKjvndn? Bdndkdk: ffjfj, fkkfk; dkflflf, fkfkfk and ksms!

Console.WriteLine("Введите ваш текст: \n");
string UserText = Console.ReadLine();

string[] WordsCalc = UserText.Split(new char[] { ' ', '.', ',', ';', '!', '?', ':', '-', '—', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
int WordsQuantity = WordsCalc.Length;
Console.WriteLine($"\n\n\nКоличество слов в тексте: {WordsQuantity}");

string[] SentencesCalc = UserText.Split(new char[] { '.', '!', '?', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
int SentencesQuantity = SentencesCalc.Length;
Console.WriteLine($"\nКоличество предложений в тексте: {SentencesQuantity}");

MatchCollection matches = Regex.Matches(UserText.ToLower(), @"\b\w+\b");
Dictionary<string, int> WordsQuantityDictionary = new Dictionary<string, int>();
foreach (Match match in matches)
{
    string Word = match.Value;
    if (WordsQuantityDictionary.ContainsKey(Word))
    {
        WordsQuantityDictionary[Word]++;
    }
    else
    {
        WordsQuantityDictionary[Word] = 1;
    }
}

Console.WriteLine("\nСамые часто встречающиеся слова:\n");
foreach (var pair in WordsQuantityDictionary)
{
    Console.WriteLine($"{pair.Key}: {pair.Value} раз.");
}

MatchCollection Lengthmatches = Regex.Matches(UserText.ToLower(), @"\b\w+\b");
int WordsMidLength = 0;
int WordsCount = Lengthmatches.Count;
foreach (Match match in Lengthmatches)
{
    WordsMidLength += match.Value.Length;
}
if (WordsCount > 0)
{
    double allLength = (double)WordsMidLength / WordsCount;
    Console.WriteLine($"\nСредняя длина слова: {allLength:F2}");
}
else
{
    Console.WriteLine("\nВы не ввели текст!");
}