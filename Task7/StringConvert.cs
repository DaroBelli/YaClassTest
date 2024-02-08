using System.Text;
using System.Text.RegularExpressions;

namespace Task7
{
    public static partial class StringConvert
    {
        [GeneratedRegex(@"\w+@\w+.[a-zA-Z]{2,3}")]
        private static partial Regex EmailRegex();

        [GeneratedRegex(@"(http|https|ftp)\://|[a-zA-Z0-9\-\.]+\.[a-zA-Z](:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;%\$#\=~])*[^\.\,\)\(\s]")]
        private static partial Regex WebSiteRegex();

        /// <summary>
        /// Заменяет email'ы и сайты в строке на '*' с помощью регулярного выражения.
        /// </summary>
        /// <param name="str">Преобразуемая строка.</param>
        /// <returns>Возвращает заменённую строку.</returns>
        public static string GetReplaceStringRegex(string str)
        {
            Regex emailRegex = EmailRegex();
            Regex webSiteRegex = WebSiteRegex();

            return ReplaceStringRegex(ReplaceStringRegex(str, emailRegex), webSiteRegex);
        }

        /// <summary>
        /// Заменяет каждый символ в строке на '*', который подпадает под условия регулярного выражения.
        /// </summary>
        /// <param name="str">Преобразуемая строка.</param>
        /// <param name="regex">Регулярное выражение.</param>
        /// <returns></returns>
        private static string ReplaceStringRegex(string str, Regex regex)
        {
            MatchCollection matches = regex.Matches(str);
            foreach (Match match in matches.Cast<Match>())
            {
                str = str.Replace(match.Value, new string('*', match.Value.Length));
            }

            return str;
        }

        /// <summary>
        /// Заменяет email'ы и сайты в строке на '*' без регулярного выражения.
        /// </summary>
        /// <param name="str">Преобразуемая строка.</param>
        /// <returns>Возвращает заменённую строку.</returns>
        public static string GetReplaceStringNotRegex(string str)
        {
            string[] words = str.Split([' ']);

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = ReplaceStringNotRegex(words[i], words[i].Contains('@') && words[i].Contains('.') && words[i].IndexOf('@') < words[i].IndexOf('.'));
                words[i] = ReplaceStringNotRegex(words[i], words[i].Contains("://") && words[i].Contains('.') && words[i].IndexOf("://") < words[i].IndexOf('.') 
                    || words[i].Split('.').Length >= 3 && words[i].Contains("www"));
            }

            return string.Join(' ', words);

        }

        /// <summary>
        /// Заменяет каждый символ в строке на '*', если она соответствует условию.
        /// </summary>
        /// <param name="str">Преобразуемая строка.</param>
        /// <param name="check">Условие преобразования.</param>
        /// <returns></returns>
        private static string ReplaceStringNotRegex(string str, bool check)
        {
            if (check)
            {
                StringBuilder specialChars = new ();
                while (!char.IsLetterOrDigit(str[^1]))
                {
                    specialChars.Insert(0, str[^1]);
                    str = str.Remove(str.Length - 1, 1);
                }
                return str.Replace(str, new string('*', str.Length)) + specialChars;
            }

            return str;
        }
    }
}
