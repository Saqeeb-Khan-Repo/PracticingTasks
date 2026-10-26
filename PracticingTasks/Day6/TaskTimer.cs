

namespace PracticingTasks.Day6;

public class TaskTimer
{
    public static async Task TimerAsync(string name, int delay)
    {
        Console.WriteLine($"{name} started");

        //Thread.Sleep(delay);
        await Task.Delay(delay);

        Console.WriteLine($"{name} finished");
    }
    //public static async Task TimerWithCancellation(string name, int delay,CancellationToken token)
    //{
    //    Console.WriteLine($"{name} started........");

    //    //Thread.Sleep(delay);
    //    await Task.Delay(delay,token);

    //    Console.WriteLine($"{name} finished");
    //}

    public static async Task Main()
    {
        Console.WriteLine("Start");

        Task task1 = TimerAsync("Task 1", 1000);
        Task task2 = TimerAsync("Task 2", 2000);
        Task task3 = TimerAsync("Task 3", 3000);
        Task task4 = TimerAsync("Task 4", 4000);
        await Task.WhenAll(task1, task2, task3, task4);

      
        /*     await WhenAll(task1, task2, task3, task4);*/
        Console.WriteLine("End");

        //CancellationTokenSource cto = new CancellationTokenSource();
        //CancellationToken token = cto.Token;
        //Task task10 = TimerWithCancellation("Task10", 4000, token);
        //cto.Cancel();
        //await task10;
    }

    //public static async Task WhenAll(Task task1 , Task task2 , Task task3 , Task task4)
    //{
    //    List<Task> listOfTasks = new List<Task>()
    //    {
    //        task1,task2,task3,task4
    //    };

    //    foreach (var task in listOfTasks)
    //    {
    //        await task;
    //    }
    //}
}
