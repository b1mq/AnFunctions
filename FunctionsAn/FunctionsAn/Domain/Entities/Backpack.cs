namespace FunctionsAn.Domain.Entities
{
    public class Backpack
    {
        public required string Color { get; init; }
        public required string Manufacturer { get; init; }
        public required string Fabric { get; init; }
        public required double Weight { get; init; }
        public required double Volume { get; init; }

        public List<Item> Items { get; private set; } = new();

        public event EventHandler<ItemAddingEventArgs>? ItemAdding;

        private double CurrentVolume => Items.Sum(i => i.Volume);

        public void AddItem(Item item)
        {
            var args = new ItemAddingEventArgs(item, CurrentVolume);
            OnItemAdding(args);

            if (args.Cancel)
                throw new InvalidOperationException("Превышен объём рюкзака");

            Items.Add(item);
        }

        protected virtual void OnItemAdding(ItemAddingEventArgs e)
        {
            if (e.CurrentVolume + e.Item.Volume > Volume)
                e.Cancel = true;

            ItemAdding?.Invoke(this, e);
        }
    }
}
