using System.Globalization;

namespace SHRBA.Invoicing.WinClient
{
    internal class InputHelper
    {
        public static T CheckIsNumeric<T>(string input)
        {
            if (typeof(T) == typeof(int))
            {
                if (int.TryParse(input, out int intValue))
                {
                    return (T)(object)intValue;
                }
            }
            else if (typeof(T) == typeof(double))
            {
                if (double.TryParse(input, out double doubleValue))
                {
                    return (T)(object)doubleValue;
                }
            }

            throw new FormatException("Please enter positve numeric values");
        }

        public static string ConvertToTitleCase(string input)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(input.ToLower());
        }
    }

}