using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Gilded_rose
{
    public class GildedRose
    {
        private ItemFactory itemFactory = new ItemFactory();
        public IList<Item> Items;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                var itemFromFactory = itemFactory.createItem(item);
                UpdateItemValues(item, itemFromFactory);
            }
        }

        private void UpdateItemValues(Item item, IItem itemFromFactory)
        {
            item.Quality = itemFromFactory.getUpdatedQuality();
            item.SellIn = itemFromFactory.getUpdatedSellIn();
        }
    }

    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }
    }
    internal interface IAbstractFactory
    {
        public IItem createItem(Item item);
    }
}