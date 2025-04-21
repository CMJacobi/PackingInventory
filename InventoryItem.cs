namespace PackingInventory;

public class InventoryItem(double weight, double volume)
{
    public double Weight { get; } = weight;
    public double Volume { get; } = volume;
}