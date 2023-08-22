namespace Console.Models
{
    public class Fruit
    {
        public string FruitID { get; set; }
        public string FruitName { get; set; }
        public int FruitAge { get; set; }
        public void EnterData()
        {
            System.Console.Write("Fruit ID = ");
            FruitID = Console.ReadLine();
            System.Console.Write("Fruit Name = ");
            FruitName = Console.ReadLine();
            System.Console.Write("Fruit Age = ");
            FruitAge = Convert.ToInt16(Console.ReadLine());
        }
        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2} Age", FruitID, FruitName, FruitAge);
        }
    }
}