namespace Console.Test
{
    public class Student : test
    {
        public float StudentID { get; set; }
        public void EnterData()
        {
            base.EnterData();
            System.Console.Write("Student ID = ");
            try{
                StudentID = Convert.ToInt16(Console.ReadLine());
            }catch(Exception e)
            {
                StudentID = 0;
            }
        }
        public void Display()
        {
            base.Display();
            System.Console.Write("_Ma sinh vien: {0}", StudentID);
        }
    }
}