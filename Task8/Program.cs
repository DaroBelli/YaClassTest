Console.WriteLine("Введите вашу строку:");

string str = Console.ReadLine() ?? string.Empty; 

Console.WriteLine($"Количество плюсов и минусов = {str.Where(x => x == '+' || x == '-').Count()}");

Console.WriteLine($"Количество элементов, перед которыми стоит 0 = {str.Split("+0").Length + str.Split("-0").Length - 2}");