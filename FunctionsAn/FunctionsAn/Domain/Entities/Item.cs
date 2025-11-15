namespace FunctionsAn.Domain.Entities
{
    public class Item
    {
        public required string Name { get; init; }
        public required double Volume { get; init; }
    }

    public class ItemAddingEventArgs : EventArgs
    {
        public Item Item { get; }
        public double CurrentVolume { get; }
        public bool Cancel { get; set; }

        public ItemAddingEventArgs(Item item, double currentVolume)
        {
            Item = item;
            CurrentVolume = currentVolume;
        }
    }
}
