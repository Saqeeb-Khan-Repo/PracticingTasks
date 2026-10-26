
namespace PracticingTasks;

public class Class2
{
    public virtual void ErrorMessage()
    {
        Console.WriteLine("Error in your code");
    }
    public static void Main()
    {
        Program p1 = new Program();
        p1.ErrorMessage();
    }
}

public class Program : Class2
{
    public  override void ErrorMessage()
    {
        Console.WriteLine("Error from program Class");
    }

   
}

