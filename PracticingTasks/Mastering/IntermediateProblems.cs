

namespace PracticingTasks.Mastering;

public class IntermediateProblems
{
    public static void Main()
    {
        //int[] nums1 = { 2, 4, 6, 8, 10 };
        //int target = 8;
        string words = "Code well, code often!";

        var result = CountTheFrequencyOfWords(words);

            Console.Write("index: "+ string.Join(" , ", result.Values , ": " ,result.Keys ));     
    }

    public static Dictionary<string,int> CountTheFrequencyOfWords(string words)
    {
        Dictionary<string, int> frequency = new Dictionary<string, int>();
        
        

        foreach (char item in words.ToLower())
        {
            //if (!char.IsLetter(item))
            //{
            //    continue; //skips non letter
            //}

            //if (frequency.ContainsKey(item))
            //{
            //    frequency[item]++;
            //}
            //else
            //{
            //    frequency[item] = 1;
            //}
          

        }

        return frequency;
    }

    //public static int ImplementBinarySearch(int[] num1, int target)
    //{
    //    int left = 0;
    //    int right = num1.Length - 1;

    //    while(left <= right)
    //    {
    //        //find mid of the array
    //        int mid = left + (right - left) / 2;

    //        if (num1[mid] == target)
    //        {
    //            return mid; //found in middle
    //        }

    //        if (num1[mid] < target)
    //        {
    //            left = mid + 1; //searches right half
    //        }
    //        else
    //        {
    //            right = mid - 1; // searches left half
    //        }
    //    }



    //    //if target not matched
    //    return -1;
    //}

    //public static int[] MergeTwoSortedArray(int[] num1, int[] num2)
    //{
    //    int[] result = new int[num1.Length + num2.Length];
    //    int i = 0; int j = 0; int k = 0;

    //    //copy elements from num1 and num2 from low => hight
    //    while(i < num1.Length && j < num2.Length)
    //    {
    //        if (num1[i] < num2[j])
    //        {
    //            result[k++] = num1[i++];
    //        }
    //        else
    //        {
    //            result[k++] = num2[j++];
    //        }
    //    }

    //    //copy remaining left elements from num1
    //    while(i < num1.Length)
    //    {
    //        result[k++] = num1[i++];
    //    }

    //    //copy remaining left elements from num2
    //    while (j < num2.Length)
    //    {
    //        result[k++] = num2[j++];
    //    }

    //    return result;

    //}
    //public static int[] TwoSum(int[] nums , int target)
    //{
    //    List<int> index = new List<int>();
    //    for (int i = 0; i < nums.Length; i++)
    //    {
    //        for (int j = i + 1; j < nums.Length; j++)
    //        {
    //            if (nums[i] == nums[j])
    //            {
    //                Console.WriteLine("Duplicates numbers");
    //                return [];
    //            }

    //            if (nums[i] + nums[j] == target)
    //            {
    //                index.Add(i);
    //                index.Add(j);
    //            }
    //        }
    //    }

    //    return index.ToArray();
    //}
}
