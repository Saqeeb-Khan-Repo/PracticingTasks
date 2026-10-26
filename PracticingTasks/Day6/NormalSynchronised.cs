
namespace PracticingTasks.Day6;


public class NormalSynchronised
{
    //before async & await
    public static void Main()
    {
        Console.WriteLine("Start");

        Thread.Sleep(5000);

        Console.WriteLine("End");
    }
    //The current thread is blocked for 5 seconds.
}
