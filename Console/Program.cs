// See https://aka.ms/new-console-template for more informationint
internal class Program
{
    private static void Main(string[] args)
    {
    string str = "97979"; //gia tri dau vao de chuyen doi
   //chuyen doi kieu du lieu string (gia tri = "97979")
   //sang kieu du lieu int (gia tri sau khi chuyen doi = 97979)
    int a = Convert.ToInt32(str);
    System.Console.WriteLine("a = " + a);
    }
}
