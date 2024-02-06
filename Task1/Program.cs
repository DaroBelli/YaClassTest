using Task1;

while (true)
{
    Console.WriteLine("Введите сумму вклада:");
    if (decimal.TryParse(Console.ReadLine(), out decimal amountDeposit))
    {
        if (amountDeposit > 0)
        {
            Console.WriteLine(Deposit.GetAmountAfterDeposit(amountDeposit));
            break;
        }
        else
        {
            Console.WriteLine("Сумма вклада не может быть отрицательной!");
        }
    }
    else
    {
        Console.WriteLine("Введите число!");
    }
    Console.WriteLine();
}