namespace Console.Models
{
    public class Employee
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public int Tuoi { get; set; }
        public int Luong { get; set; }
        // public void EnterData()
        // {
        //     System.Console.Write("Ma nhan vien = ");
        //     MaNV = Console.ReadLine();
        //     System.Console.Write("Ten nhan vien = ");
        //     TenNV = Console.ReadLine();
        //     System.Console.Write("Tuoi = ");
        //     Tuoi = Convert.ToInt16(Console.ReadLine());
        //     System.Console.Write("Luong = ");
        //     Luong = Convert.ToInt16(Console.ReadLine());
        //}
        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2} tuoi - {3} vnd", MaNV, TenNV, Tuoi, Luong);
        }
    }
}