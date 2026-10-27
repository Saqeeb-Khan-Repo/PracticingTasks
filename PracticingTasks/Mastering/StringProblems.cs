
namespace PracticingTasks.Mastering;

public class StringProblems
{
    public static void Main()
    {
        string str1 = "silent";
        string str2 = "listen";

        var result = CheckAnagram(str1,str2);
        Console.WriteLine("isAnagram: "+result);

    }
    public static bool CheckAnagram(string s1,string s2)
    {
        string a = new string(s1.ToLower().Where(char.IsLetter).OrderBy(a => a).ToArray());
        string b = new string(s2.ToLower().Where(char.IsLetter).OrderBy(a => a).ToArray());

        return a == b;
    }

    //public static Dictionary<char,int> CountCharFrequency(string s)
    //{
    //    Dictionary<char, int> frequency = new Dictionary<char, int>();

    //    foreach (char item in s.ToLower())
    //    {
    //        if (!char.IsLetter(item))
    //        {
    //            continue; //skip
    //        }
    //        if (frequency.ContainsKey(item))
    //        {
    //            frequency[item]++;
    //        }
    //        else
    //        {
    //            frequency[item] = 1;
    //        }

    //    }

    //    return frequency;
    //}

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
