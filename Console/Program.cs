public class Program
{
    private static void Main(string[] args)
    {
        int n = 0;
        do
        {
            System.Console.WriteLine("n = ");
            n = Convert.ToInt32(Console.ReadLine());
        } while (n < 1);
        Test [] TestArray = new Test[n];
        for (int i = 0; i <TestArray.Length; i++)
        {
            Test ts = new Test();
            ts.EnterData();
            TestArray[i] = ts;
        }
    }
}