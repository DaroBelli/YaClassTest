namespace Task1
{
    public static class Deposit
    {
        /// <summary>
        /// Возвращает процент по вкладу, взависимости от начального вклада.
        /// </summary>
        /// <param name="amountDeposit">Начальный вклад.</param>
        /// <returns></returns>
        private static int GetPercentage(decimal amountDeposit)
        {
            if (amountDeposit < 100)
            {
                return 5;
            }
            else if (amountDeposit >= 100 && amountDeposit <= 200)
            {
                return 7;
            }

            return 10;
        }

        /// <summary>
        /// Возвращает сумму вклада после начисления процентов.
        /// </summary>
        /// <param name="amountDeposit">Начальный вклад.</param>
        /// <returns></returns>
        public static decimal GetAmountAfterDeposit(decimal amountDeposit)
        {
            return Math.Round(amountDeposit * (1 + GetPercentage(amountDeposit) / (decimal)100), 2, MidpointRounding.AwayFromZero);
        }
    }
}
