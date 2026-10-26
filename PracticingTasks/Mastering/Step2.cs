

namespace PracticingTasks.Mastering;

public class Step2
{

    //public static void Main()
    //{
    //    int[] marks = { 45, 78, 32, 90, 78, 56, 23, 90, 67 };

    //    if(marks.Length == 0)
    //    {
    //        Console.WriteLine("No marks Available");
    //        return;
    //    }

    //    int highest = marks[0];
    //    int lowest = marks[0];
    //    int IsPassed = 0;
    //    int SecondHighest = int.MinValue;
    //    int total = 0;

    //    foreach (var item in marks)
    //    {
    //        //total
    //        total += item;

    //        //passed students
    //        if(item >= 35)
    //        {
    //            IsPassed++;
    //        }

    //        //highest
    //        if(item > highest)
    //        {
    //            SecondHighest = highest;
    //            highest = item;
    //        }

    //        //lowest
    //        if(item < lowest)
    //        {
    //            lowest = item;
    //        }

    //        //Second Highest
    //        if(item > SecondHighest & item < highest)
    //        {
    //            SecondHighest = item;
    //        }
    //    }

    //    double Average = (double)total / marks.Length;

    //    Console.WriteLine($"Highest : {highest}");
    //    Console.WriteLine($"Lowest : {lowest}");
    //    Console.WriteLine($"Average marks : {Average}");
    //    Console.WriteLine($"Students Passed : {IsPassed}");
    //    Console.WriteLine($"SecondHighest : {SecondHighest}");
    //}

    //public static void Main()
    //{
    //    int[] marks = { 10, 20, 30, 40, 50 };

    //    if(marks.Length == 0)
    //    {
    //        Console.WriteLine("No Marks are Avilable");
    //        return;
    //    }

    //    int total = 0;
    //    int AboveAverage = 0;
    //    double Average = 0;
    //    foreach (var item in marks)
    //    {
    //        total += item;
    //    }

    //    Average = (double)total / marks.Length;


    //    Console.WriteLine($"Average marks is : {Average}");

    //    foreach (var item in marks)
    //    {
    //        if (item > Average)
    //        {
    //            AboveAverage++;
    //        }
    //    }

    //    Console.WriteLine($"above average : {AboveAverage}");

    //}

    //public static void  Main()
    //{

    //    int[] marks = { 10, 20, 10, 30, 20, 10, 40, 20, 20 };
    //    int mostFrequentMark = marks[0]; //count
    //    int highestFrequency = 0;//target

    //    foreach (var target in marks)
    //    {
    //        int count = 0;
    //        foreach (var item in marks)
    //        {
    //            if(item == target)
    //            {
    //                count++;
    //            }
    //        }

    //        if(count > highestFrequency)
    //        {
    //            highestFrequency = count;
    //            mostFrequentMark = target;
    //        }

    //    }


    //    Console.WriteLine($"Most frequent mark: {mostFrequentMark}");
    //    Console.WriteLine($"Number of occurrences: {highestFrequency}");


    //}
}
