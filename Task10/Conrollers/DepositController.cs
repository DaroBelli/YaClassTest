namespace Task10.Conrollers
{
    public static class DepositController
    {
        /// <summary>
        /// Возвращает конечный вклад.
        /// </summary>
        /// <param name="deposit">Начальный вклад.</param>
        /// <param name="monthCount">Количество месяцев.</param>
        /// <returns></returns>
        public static decimal GetDepositFromProcent(decimal deposit, int monthCount)
        {
            int percent = int.Parse(ConfigJSON.GetConfig().GetSection("Percent").Value ?? "0");
            for (int i = 0; i < monthCount; i++)
            {
                deposit *= (percent + 100) / (decimal)100;
            }

            return Math.Round(deposit, 2, MidpointRounding.AwayFromZero);
        }
    }
}
