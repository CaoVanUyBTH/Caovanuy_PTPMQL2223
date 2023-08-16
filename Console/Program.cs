// See https://aka.ms/new-console-template for more informationint
internal class Program
{
    private static void Main(string[] args)
    {
        int a = 2;
        do
        {
            System.Console.WriteLine("Vong lap thu {0}", a);
            //tang a len 1 don vi de dam bao co luc a >= 10
            //a >= 10 thi vong lap se ket thuc
            a++;
        }while(a < 10);
    }
}
