namespace Week8;

public class CargoContainer<T> where T: DeliveryItem
{
    private List<T> _items = new List<T>();

    public void AddItem(T item)
    {
        _items.Add(item);
        Console.WriteLine($"Added: {item.TrackingNumber}.");
    }

    public double GetTotalCost()
    {
        double tot = 0;
        foreach (var i in _items)
        {
            tot += i.CalculateCost();
        }

        return tot; 
    }
}