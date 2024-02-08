string str = "тестовый ++ т0ек+с0т - выполнение";

Console.WriteLine($"Количество плюсов и минусов = {str.Where(x => x == '+' || x == '-').Count()}");

int count = str.Where( x => x == '0' ).Count();
if (str.StartsWith( '0' ) )
    count--;
Console.WriteLine($"Количество элементов, перед которыми стоит 0 = {count}");