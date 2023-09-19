using System.Security.AccessControl;
namespace N.Test
{
    public class Test
    {
        public int TestID {get; set;}
        public string TestName {get; set;}
        public string TestDiachi {get; set;} 
        public void EnterData()
        {
            System.Console.Write("TestID = ");
            TestID = Console.Read();
            System.Console.Write("TestName = ");
            TestName = Console.ReadLine();
            System.Console.WriteLine("TestDiachi = ");
             try{
                TestDiachi = Convert.ToInt16(Console.ReadLine());
            }catch(Exception e)
            {
                TestDiachi = 0;
            }
        }
        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2}", TestID, TestName, TestDiachi);
        }
    }
}