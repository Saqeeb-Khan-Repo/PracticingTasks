

namespace PracticingTasks.Day7;

public class TryCatch
{
    public static async Task Main()
    {
        //Exception Handling
        try
        {
            CancellationTokenSource cto = new CancellationTokenSource();
            CancellationToken token = cto.Token;
            Console.WriteLine("Coding......");
              cto.Cancel();//error 
            await Task.Delay(5000,token);
          
            Console.WriteLine("Coding Completed");
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error in Coding : {ex.Message}");
        }



    }
}
