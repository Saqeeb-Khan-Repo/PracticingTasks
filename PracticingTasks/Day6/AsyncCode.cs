
namespace PracticingTasks.Day6;


public class AsyncCode
{
    //after async & await
    public static async Task Download(int delay , string name )
    {
        Console.WriteLine($"Downloading {name}.......");
        await Task.Delay(delay);
        Console.WriteLine($"Download Completed {name}");
        Console.WriteLine();
            
    }

    public static async Task Main()
    {
        Console.WriteLine("Start");
        await  Download(3000, "task1");
        await Download(3000, "task2");
        await Download(3000, "task3");

        Console.WriteLine("End");
    }
    //The current thread is blocked for 5 seconds.
}
