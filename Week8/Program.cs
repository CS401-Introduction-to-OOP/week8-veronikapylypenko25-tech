using Week8;

namespace Week8;

class Program
{
    static void Main(string[] args)
    {
        Letter l1 = new Letter("N1", 0.1);
        Letter l2 = new Letter("N2", 0.2);
        Parcel p1 = new Parcel("30x20x15", "P1", 5);
        Parcel p2 = new Parcel("30x60x15", "P2", 6);
        l1.PrintInfo();
        p1.PrintInfo();

        CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
        myCargo.AddItem(l1);
        myCargo.AddItem(l2);
        myCargo.AddItem(p1);
        myCargo.AddItem(p2);
        double totCost = myCargo.GetTotalCost();
        Console.WriteLine($"Delivery total cost: {totCost}  UAH. ");
    }
}