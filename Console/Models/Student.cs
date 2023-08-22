namespace Console.Models
{
    public class Student
    {
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public string Diachi { get; set; }
        public void EnterData()
        {
            System.Console.Write("Ma sinh vien = ");
            MaSV = Console.ReadLine();
            System.Console.Write("Ten sinh vien = ");
            TenSV = Console.ReadLine();
            System.Console.Write("Dia chi = ");
            Diachi = Console.ReadLine();
        }
        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2}", MaSV, TenSV, Diachi);
        }
    }
}