using System;
using System.Text.RegularExpressions;

//ТЕСТОВЫЙ ТЕКСТ ДЛЯ ПРОВЕРКИ:
// Fshdjdd. Jfjdkmffkj, mfnndfk, mfkmfmk. Bjsdkdjk!!! JKjvndn? Bdndkdk: ffjfj, fkkfk; dkflflf, fkfkfk and ksms!

Console.WriteLine("Введите ваш текст: \n");
string theTextEnteredByTheUser = Console.ReadLine();

string[] CountingWordsInTheTextEnteredByTheUser = theTextEnteredByTheUser.Split(new char[] { ' ', '.', ',', ';', '!', '?', ':', '-', '—', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
int theNumberOfWordsInTheTextEnteredByTheUser = CountingWordsInTheTextEnteredByTheUser.Length;
Console.WriteLine($"\n\n\nКоличество слов в тексте: {theNumberOfWordsInTheTextEnteredByTheUser}");

string[] CountTheNumberOfSentencesInTheTextEnteredByTheUser = theTextEnteredByTheUser.Split(new char[] { '.', '!', '?', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
int theNumberOfSentencesInTheTextEnteredByTheUser = CountTheNumberOfSentencesInTheTextEnteredByTheUser.Length;
Console.WriteLine($"\nКоличество предложений в тексте: {theNumberOfSentencesInTheTextEnteredByTheUser}");

MatchCollection matches = Regex.Matches(theTextEnteredByTheUser.ToLower(), @"\b\w+\b");
Dictionary<string, int> NumberOfWordsDictionary = new Dictionary<string, int>();
foreach (Match match in matches)
{
    string Word = match.Value;
    if (NumberOfWordsDictionary.ContainsKey(Word))
    {
        NumberOfWordsDictionary[Word]++;
    }
    else
    {
        NumberOfWordsDictionary[Word] = 1;
    }
}

Console.WriteLine("\nСамые часто встречающиеся слова:\n");
foreach (var pair in NumberOfWordsDictionary)
{
    Console.WriteLine($"{pair.Key}: {pair.Value} раз.");
}

MatchCollection LengthMatches = Regex.Matches(theTextEnteredByTheUser.ToLower(), @"\b\w+\b");
int averageLengthOfWords = 0;
int numberOfWords = LengthMatches.Count;
foreach (Match match in LengthMatches)
{
    averageLengthOfWords += match.Value.Length;
}
if (numberOfWords > 0)
{
    double theAverageLengthOfAWordAmongAllWords = (double)averageLengthOfWords / numberOfWords;
    Console.WriteLine($"\nСредняя длина слова: {theAverageLengthOfAWordAmongAllWords:F2}");
}
else
{
    Console.WriteLine("\nВы не ввели текст!");
}