using System.Text;
using System.Text.RegularExpressions;

namespace HomeWork.Lesson5.Task1
{
    internal static class InputCheck
    {
        internal static int Try { get; set; }
        internal static bool BoolRegexOff(string target)
        {

            var targetDecompose = target.ToCharArray();

            if (targetDecompose.Length < 2 || targetDecompose.Length > 10)
                return true;

            var zeroChar = Encoding.ASCII.GetBytes(targetDecompose)[0];
            if(zeroChar >= 48 && zeroChar <= 57)
                return true;

            for (var i = 1; i < targetDecompose.Length; i++)
            {
                var targetChar = Encoding.ASCII.GetBytes(targetDecompose)[i];
                if ( (targetChar < 65 || targetChar > 90) && (targetChar < 97 || targetChar > 122) && (targetChar < 48 || targetChar > 57))
                {
                    return true;
                }
            }

            return false;
        }

        internal static bool BoolRegexOn(string target)
        {
            
            var pattern = @"^[a-zA-Z][a-zA-Z0-9]{1,8}$";
            var match = Regex.Match(target, pattern, RegexOptions.IgnoreCase);

            if (match.Success)
                return false;

            return true;
        }
    }
}