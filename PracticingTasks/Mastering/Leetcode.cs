

using System.Net.Http.Headers;

namespace PracticingTasks.Mastering;

public class Leetcode
{
    //public static void Main()
    //{
    //    int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 , 10 ,11, 10 , 22,23 };

    //    //Console.WriteLine(MaxArea(height));

    //    int[] result = Reverse(height);

    //    Console.WriteLine(string.Join(", " , result));

    //}

    //public static int[] Reverse(int[] integers)
    //{
    //    List<int> reversed  = new List<int>();
    //    for (int i = integers.Length - 1; i >= 0; i--)
    //    {
    //        reversed.Add(integers[i]);
    //    }
    //    return reversed.ToArray();
    //}
    //public static int MaxArea(int[] height)
    //{
    //    int maxWater = 0;

    //    for (int left = 0; left < height.Length; left++)
    //    {
    //        for (int right = left + 1; right < height.Length; right++)
    //        {
    //            int width = right - left;

    //            int minHeight = Math.Min(
    //                height[left],
    //                height[right]   
    //            );

    //            int area = width * minHeight;

    //            maxWater = Math.Max(maxWater, area);
    //        }
    //    }

    //    return maxWater;
    //}

    //public static void Main()
    //{
    //    //int[] numbers = { 302, 152, 132, 122, 112 };
    //int average = 0;
    //int sum = 0;

    //foreach (var item in numbers)
    //{
    //    sum += item;
    //}

    //average = sum / numbers.Length;

    //Console.WriteLine(average);
    //Console.WriteLine("Enter first number: ");
    //int a = Convert.ToInt32(Console.ReadLine());

    //Console.WriteLine("Enter Second number: ");
    //int b = Convert.ToInt32(Console.ReadLine());

    //Console.WriteLine("Enter operator from options => (+ , - , / , *): ");
    //char op = Convert.ToChar(Console.ReadLine()!);


    //var result = Calculator(a, b, op);
    //Console.WriteLine("total = " + result);


    //Console.WriteLine(SumDigits(5832)); 

    //    Console.WriteLine("Palinedrome = " + CheckPalinedromeNumber(121));

    //    //Console.WriteLine(Factorial(5));
    //}

    //public static int Factorial(int n)
    //{
    //    if(n <= 0)
    //    {
    //        Console.WriteLine("Invalid number");
    //        return 0;
    //    }

    //    int factorial = 1;

    //    for (int i = 1; i <= n; i++)
    //    {
    //        factorial = factorial * i;
    //    }

    //    return factorial;
    //}

    //public static bool CheckPalinedromeNumber(int number)
    //{
    //    int prevNumber = number;

    //    if (number <= 0)
    //    {
    //        Console.WriteLine("Invalid Numbers");
    //        return false;
    //    }

    //    int reversed = 0;
    //    while (number > 0)
    //    {
    //        int lastNum = number % 10;//1 2 .1
    //        reversed = reversed * 10 + lastNum;// 1 , 12  , 121
    //        number = number / 10;
    //    }

    //    if(prevNumber == reversed)
    //    {
    //        return true;
    //    }

    //    return false;

    //}


    //public static int ReverseNumber(int number)
    //{
    //    if(number <= 0)
    //    {
    //        Console.WriteLine("Invalid Numbers");
    //        return 0;
    //    }

    //    int reversed = 0;
    //    while(number > 0)
    //    {
    //        int lastNum = number % 10;//123.4
    //        reversed = reversed * 10 + lastNum;// 4 , 43 , 432 , 4321
    //        number = number / 10;

    //    }
    //    return reversed;
    //}

    //public static int SumDigits(int digits)
    //{
    //    int sum = 0;
    //    while(digits > 0)
    //    {
    //        int lastDigit = digits % 10; //583.2 gets 2 
    //        sum += lastDigit; //add 2 in sum
    //        digits = digits / 10; //remove the last digit 2 like that loop continues until it become zero
    //    }

    //    return sum;
    //}
    //public static int Calculator(int a, int b, char oper)
    //{
    //    char[] operators = { '+', '-', '/', '*' };

    //    if (a <= 0 || b <= 0)
    //    {
    //        Console.WriteLine("Zero and negative numbers not supported");
    //        return 0;
    //    }
    //    switch (oper)
    //    {
    //        case '+':
    //            return a + b;
    //        case '-':
    //            return a - b;
    //        case '*':
    //            return a * b;
    //        case '/':
    //            return a / b;
    //        default:
    //            Console.WriteLine("Invalid Operator");
    //            return 0;
    //    }
    //}

    //public static bool IsPrime(int num)
    //{

    //    if(num <= 0)
    //    {
    //        Console.WriteLine("Invalid numbers");
    //        return false;
    //    }

    //    if(num % 2 == 0)
    //    {
    //        return true;
    //    }

    //    return false;
    //}

    public static void Main()
    {
        //Console.WriteLine(IsPrime(7));

        int[] arr = { 5, 10, 15, 20, 25 };
        int k = 3;
        var result = RotateArrayToRight(arr,k);
        foreach (var item in result)
        {
            Console.Write(item + " , ");
        }
       
    }
    public static int[] RotateArrayToRight(int[] arr, int k)
    {
        int n = arr.Length;
        if (n <= 0)
        {
            Console.WriteLine("error no values available");
            return arr;
        }

        k = k % n;//2 roation

        if(k == 0)
        {
            return [];
        }

        // Step 1: Reverse the entire array.
        Reverse(arr, 0, n - 1);

        // Step 2: Reverse the first k elements.
        Reverse(arr, 0, k - 1);

        // Step 3: Reverse the remaining elements.
        Reverse(arr, k, n - 1);
        return arr;
    }

    public static void Reverse(int[] arr , int left , int right)
    {
        while(left < right)
        {
            int temp = arr[left]; //arr[0]
            arr[left] = arr[right];
            arr[right] = temp;

            left++;//0,1,2,3,4
            right--;//4,3,2,1,0
        }
    }

    //public static int[] RemoveDuplicate(int[] arr)
    //{
    //    if (arr.Length <= 0)
    //    {
    //        Console.WriteLine("error no values available");
    //        return arr;
    //    }
    //    HashSet<int> removed = new HashSet<int>(); // only add unique and automatically remove duplicates

    //    foreach (var item in arr)
    //    {
    //        removed.Add(item);
    //    }

    //    return removed.ToArray();

    //}



    //public static int[] ReverseArray(int[] arr) //best approach
    //{
    //    int n = arr.Length;

    //    if (n <= 0)
    //    {
    //        Console.WriteLine("error no values available");
    //        return arr;
    //    }
    //    int left = 0;
    //    int right = n - 1;//arr.length - 1 => 5 - 1 = 4

    //    //to reverse
    //    while (left < right)//0 < 4 
    //    {
    //        int temp = arr[left];//arr[0] = 1
    //        arr[left] = arr[right];//swap arr[0] = arr[4] => 5;
    //        arr[right] = temp;//swap arr[4] = arr[0] => 1;

    //        left++;//0,1,2,3,4
    //        right--;//4,3,2,1,0
    //    }

    //    return arr;

    //}

    //public static int FIndSecLargestDistinct(int[] arr)
    //{
    //    int largest = arr[0];
    //    int secondLargest = 0;

    //    foreach (var item in arr)
    //    {
    //        //validation
    //        if(item <= 0)
    //        {
    //            Console.WriteLine("invalid numbers");
    //            return 0;
    //        }

    //        //find largest
    //       if(item >= largest)
    //        {
    //            largest = item;//10
    //        }

    //        //find second largest
    //        if (item != largest && item >= secondLargest ) //not equal to largest + greater than secondlargest
    //        {
    //            secondLargest = item;
    //        }

    //        ////check for duplicates
    //        //if( item == largest )
    //        //{
    //        //    Console.WriteLine("No second Highest value exists ,found duplicates values ");
    //        //    return 0;
    //        //}
    //    }

    //    return secondLargest;
    //}

    //public static int  FindAverage(int[] arr)
    //{
    //    int average = 0;
    //    int sum = 0;
    //    int length = 0;

    //    foreach (var item in arr)
    //    {
    //        if(item > 0)
    //        {
    //            sum += item;
    //            length++;
    //        }
    //    }
    //    average = sum / length;

    //    return average;
    //}

    //public static (int even , int odd)  EVENODD(int[] arr)
    //{
    //    int even = 0;
    //    int odd = 0;

    //    foreach (var item in arr)
    //    {
    //        if (item % 2 == 0)
    //        {
    //            even++;
    //        }
    //        if (item % 2 == 1)
    //        {
    //            odd++;
    //        }
    //    }
    //    return (even, odd);     
    //}
    //public static (int max, int min) FindMaxMin(int[] arr)
    //{
    //    int max = arr[0];
    //    int min = arr[0];

    //    foreach (var item in arr)
    //    {
    //        if(item > max)
    //        {
    //            max = item;
    //        }
    //        if(item < min)
    //        {
    //            min = item;
    //        }
    //    }
    //    return (max, min);
    //}

}
