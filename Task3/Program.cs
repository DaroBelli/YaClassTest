using Task3;

int[] mas = [6, 7, 2, 3, 9, 4, 7, 1, 3, 6, 8, 3, 7, 8, 3];

int position = Position.GetMinSumWithRight(mas);

Console.WriteLine($"Сумма значений: {mas[position]} и {mas[position + 1]}, находящихся в массиве на позициях: {position} и {position + 1} - является минимальной " +
    $"и равняется: {mas[position] + mas[position + 1]}");
