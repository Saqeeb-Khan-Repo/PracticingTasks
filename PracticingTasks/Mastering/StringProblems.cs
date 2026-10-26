
namespace PracticingTasks.Mastering;

public class StringProblems
{
    public static void Main()
    {
        string str = "Hello";
        var result = CountCharFrequency(str);
        foreach (var pair in result)
        {
            Console.Write($"{pair.Key}: {pair.Value}, ");
        }

    }

    public static Dictionary<char,int> CountCharFrequency(string s)
    {
        Dictionary<char, int> frequency = new Dictionary<char, int>();

        foreach (char item in s.ToLower())
        {
            if (!char.IsLetter(item))
            {
                continue; //skip
            }
            if (frequency.ContainsKey(item))
            {
                frequency[item]++;
            }
            else
            {
                frequency[item] = 1;
            }
          
        }

        return frequency;
    }

    //public static (int vol , int caso) CountVowelsAndCasonants(string s)
    //{
    //    int vowelCount = 0;
    //    int casonantCount = 0;
    //    string vowels = "aeiou";
    //    foreach (char item in s.ToLower())
    //    {
    //        if (!char.IsLetter(item))
    //        {
    //            continue;
    //        }

    //        if (vowels.Contains(item))
    //        {
    //            vowelCount++;
    //        }

    //        if (!vowels.Contains(item))
    //        {
    //            casonantCount++;
    //        }
    //    }

    //    return (vowelCount, casonantCount);
    //}

    //public static bool CheckPalinedrome(string s)
    //{
    //    int left = 0;
    //    int right = s.Length - 1;

    //    while(left < right)
    //    {
    //        if (s[left] != s[right])
    //            return false;

    //        left++;
    //        right--;
    //    }

    //    return true;
    //}

    //public static string ReverseAString(string str)
    //{
    //    string newString = "";
    //    for (int i = str.Length - 1 ; i >= 0; i--)
    //    {
    //        newString += str[i];
    //    }

    //    return newString;
    //}
}
