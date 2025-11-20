using System.Text.RegularExpressions;

namespace OC.Assistant.Sdk;

/// <summary>
/// <see cref="string"/> extension methods.
/// </summary>
public static class StringExtension
{
    /// <param name="value">The input string to be converted.</param>
    extension(string value)
    {
        /// <summary>
        /// Converts a string of numbers (e.g. 1,2,3,4,16-32,64-128) into a list.
        /// </summary>
        public int[] ToNumberList()
        {
            var res = new List<int>();
            const string pattern = @"(?<val>((?<low>\d+)\s*?-\s*?(?<high>\d+))|(\d+))";

            foreach (Match m in Regex.Matches(value, pattern))
            {
                if (!m.Groups["val"].Success) continue;
                
                //found area (e.g. 16-32)
                if (m.Groups["low"].Success && m.Groups["high"].Success)
                {
                    var low = Convert.ToInt32(m.Groups["low"].Value);
                    var high = Convert.ToInt32(m.Groups["high"].Value);
                    for (var i = low; i <= high; i++)
                    {
                        res.Add(i);
                    }
                    continue; //next match
                }
                res.Add(Convert.ToInt32(m.Groups["val"].Value)); //single value

            }
            return res.ToArray();
        }

        /// <summary>
        /// Removes the description in brackets, e.g. KF2.1 (EL1008) => KF2.1
        /// </summary>
        public string TcRemoveBrackets()
        {
            const string pattern = @"(\S+)\(\S+\)";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            var match = regex.Match(value.Replace(" ", ""));
            return match.Success ? match.Groups[1].ToString() : value;
        }

        /// <summary>
        /// Replaces any character except a-z A-Z and 0-9 with a underscore.<br/>
        /// Underscores at start and end will be removed.
        /// </summary>
        public string TcPlcCompatibleString()
        {
            var str =  Regex.Replace(value, "[^a-zA-Z0-9]+", "_");
            str = str.StartsWith('_') ? str.Remove(0, 1) : str;
            str = str.EndsWith('_') ? str.Remove(str.Length - 1) : str;
            return str;
        }

        /// <summary>
        /// Returns the string with the first letter capitalized.
        /// </summary>
        public string FirstCharToUpper()
        {
            if (string.IsNullOrEmpty(value)) return "";
            return value.Length == 1 ? $"{char.ToUpper(value[0])}" : $"{char.ToUpper(value[0])}{value[1..]}";
        }

        /// Converts the input string to a format compatible with PLC naming conventions.
        /// <return>Returns the PLC-compatible string. If the input string is already PLC-compatible, it is returned unchanged; otherwise, it is wrapped with backticks (`).</return>
        public string MakePlcCompatible()
            => value.IsPlcCompatible() ? value : $"`{value}`";

        /// <summary>
        /// Checks if the input string is compatible with PLC naming conventions.
        /// </summary>
        /// <returns>Returns <c>true</c> if the input string is PLC compatible; otherwise, <c>false</c>.</returns>
        public bool IsPlcCompatible()
            => !string.IsNullOrEmpty(value) && !InvalidCharacters.IsMatch(value);
    }

    private static Regex InvalidCharacters { get; } = new ("[^a-zA-Z0-9_]+");
}