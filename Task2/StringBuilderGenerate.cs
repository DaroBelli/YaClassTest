using System.Text;

namespace Task2
{
    public static class StringBuilderGenerate
    {
        /// <summary>
        /// Возвращает объект StringBuilder по полученному трёхмерному массиву.
        /// </summary>
        /// <param name="mas">Трёхмерный массив</param>
        /// <returns></returns>
        public static StringBuilder GetStringBuilder(int[,,] mas)
        {
            StringBuilder sb = new("{");

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                sb.Append('{');
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    sb.Append('{');
                    for (int k = 0; k < mas.GetLength(2); k++)
                    {
                        sb.Append($"{mas[i, j, k]} , ");
                    }
                    sb.Remove(sb.Length - 3, 3);
                    sb.Append("} , ");
                }
                sb.Remove(sb.Length - 3, 3);
                sb.Append("} , ");
            }
            sb.Remove(sb.Length - 3, 3);
            sb.Append('}');
            return sb;  
        }
    }
}
