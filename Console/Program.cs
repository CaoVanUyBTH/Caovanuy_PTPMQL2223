// See https://aka.ms/new-console-template for more informationint
internal class Program
{
    private static void Main(string[] args)
    {
        int a, b; //Khai bao 2 bien so a va b kieu int
        //thong bao cho nguoi dung nhap vao a
        System.Console.Write("a = ");
        //doc du lieu nhap tu ban phim chuyen snag kieu int va gan cho a
        a = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("b = ");
        //doc du lieu nhap tu ban phim chuyen snag kieu int va gan cho b
        b = Convert.ToInt32(Console.ReadLine());
        //in tong a + b ra ngoai man hinh
        System.Console.WriteLine("{0} / {1} = {2}", a, b, a/b);
        System.Console.WriteLine("{0} % {1} = {2}", a, b, a%b);
    }
}
