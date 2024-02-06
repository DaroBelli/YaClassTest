namespace Task3
{
    public static class Position
    {
        /// <summary>
        /// Возвращает позицию элемента, сумма которого с правым соседом в массиве минимальна.
        /// </summary>
        /// <param name="mas">Массив, в котором нужно найти позицию элемента.</param>
        /// <returns></returns>
        public static int GetMinSumWithRight(int[] mas)
        {
            int position = 0;

            int min = mas[0] + mas[1];

            for (int i = 1; i < mas.Length - 1; i++)
            {
                if (mas[i + 1] < min)
                {
                    int sum = mas[i + 1] + mas[i];
                    if (sum < min)
                    {
                        position = i;
                        min = sum;
                    }
                }
                else
                {
                    i++;
                }
            }

            return position;
        }
    }
}
