using System.Text.RegularExpressions;

namespace OC.Assistant.Sdk;

/// <summary>
/// <see cref="string"/> extension methods.
/// </summary>
public static partial class StringExtension
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

            foreach (Match m in NumberListRegex().Matches(value))
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
        /// Returns the string with the first letter capitalized.
        /// </summary>
        public string FirstCharToUpper()
        {
            if (string.IsNullOrEmpty(value)) return "";
            return value.Length == 1 ? $"{char.ToUpper(value[0])}" : $"{char.ToUpper(value[0])}{value[1..]}";
        }

        /// <summary>
        /// Checks if the input string only contains the characters <c>a-z</c> <c>A-Z</c> <c>0-9</c> and <c>_</c>
        /// </summary>
        /// <returns>True if the input string only contains basic characters, otherwise False.</returns>
        public bool IsBasicCharacters()
            => !string.IsNullOrEmpty(value) && !BasicCharactersRegex().IsMatch(value);
    }
    
    [GeneratedRegex(@"(?<val>((?<low>\d+)\s*?-\s*?(?<high>\d+))|(\d+))")]
    private static partial Regex NumberListRegex();
    
    [GeneratedRegex("[^a-zA-Z0-9_]+")]
    private static partial Regex BasicCharactersRegex();
}