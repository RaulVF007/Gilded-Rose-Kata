using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Gilded_rose.ItemsFolder;

namespace Gilded_rose
{
    public class GildedRose
    {
        private ItemsFactory itemFactory = ItemsFactory.Instance;
        public IList<Item> Items;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                item.Quality = itemFactory.GetInstanceFromExistentItem(item).GetUpdatedQuality();
                item.SellIn = itemFactory.GetInstanceFromExistentItem(item).GetUpdatedSellIn();
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }
    }
}