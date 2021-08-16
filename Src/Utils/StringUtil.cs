using System;

namespace CrashCourse2021ExercisesDayOne.Utils
{
    internal class StringUtil
    {
        internal int LengthOfString(string stringToMeasure)
        {
            if (stringToMeasure == null)
            {
                throw new NullReferenceException(Constants.StringCannotBeNull);
            }

            return stringToMeasure.Length;
        }

        internal string SumStrings(string value1, string value2)
        {
            return (int.Parse(value1) + int.Parse(value2)).ToString();
        }

        internal string DivideString(string value1, string value2)
        {
            return (int.Parse(value1) / int.Parse(value2)).ToString();
        }

        internal string StringContains(string value1, string value2)
        {
            if (value1.Contains(value2))
            {
                return "YES";
            }

            return "NO";
        }

        internal string StringToUpperCase(string value1)
        {
            return value1.ToUpper();
        }

        internal string AdditionFromPlusString(string inputString)
        {
            string[] numbers = inputString.Split("+");
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += int.Parse(number);
            }

            return sum.ToString();
        }

        internal string EvenNumber(int numbertoTest)
        {
            return numbertoTest % 2 == 0 ? Constants.Even : Constants.Odd;
        }
    }
}