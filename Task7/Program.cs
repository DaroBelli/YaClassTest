using Task7;

Console.WriteLine("Введите вашу строку:");

string str = Console.ReadLine() ?? string.Empty;

Console.WriteLine(StringConvert.GetReplaceStringRegex(str));
Console.WriteLine(StringConvert.GetReplaceStringNotRegex(str));