namespace NewApp.Models.Models
{
    public class Person 
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public void Display2(string ten, int tuoi)
        {
            System.Console.WriteLine("Sinh vien {0} - {1} tuoi", ten, tuoi);
        }
        public int GetYear0fBirth(int age)
        {
            int year0fBirth = 2023 - age;
            return year0fBirth;
        }
        public void EnterData()
         {
             System.Console.Write("Full name = ");
             FullName = Console.ReadLine();
            System.Console.Write("Address = ");
             Address = Console.ReadLine();
             System.Console.Write("Age = ");
             Age = Convert.ToInt16(Console.ReadLine());
         }
        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2} tuoi", FullName, Address, Age);
        }
        public void Display(string ten, int tuoi)
        {
            System.Console.WriteLine("Sinh vien {0} - {1} tuoi", ten, tuoi);
        }
    }
}