
using NewApp.Models.Models;

public class Program
{
    private static void Main(string[]args)
    {
        //Khoi tao doi tuong ps tu class Person
        Person ps = new Person();
        string str = "Nguyen Van A";
        int a = 22;
        Console.WriteLine("{0} sinh nam {1}", str, ps.GetYear0fBirth(a));
    }
}