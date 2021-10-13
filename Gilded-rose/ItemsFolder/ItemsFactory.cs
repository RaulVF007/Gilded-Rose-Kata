namespace Gilded_rose.ItemsFolder
{
    class ItemsFactory
    {
        public static ItemsFactory Instance { get; } = new ItemsFactory();
        private ItemsFactory()
        {
        }

        public IItem GetInstanceFromExistentItem(Item item)
        {
            return item.Name switch
            {
                "Aged Brie" => MakeBrieItem(item.Quality, item.SellIn),
                "Sulfuras, Hand of Ragnaros" => MakeLegendaryItem(item.Quality, item.SellIn),
                "Backstage passes to a TAFKAL80ETC concert" => BackstageItem(item.Quality, item.SellIn),
                "Conjured" => MakeConjuredItem(item.Quality,item.SellIn),
                _ => NormalItem(item.Quality, item.SellIn)
            };
        }

        private ConjuredItem MakeConjuredItem(int itemQuality, int itemSellIn)
        {
            return new ConjuredItem(itemQuality,itemSellIn);
        }

        public BrieItem MakeBrieItem(int quality, int sellIn)
        {
            return new BrieItem(quality, sellIn);
        }

        public LegendaryItem MakeLegendaryItem(int quality, int sellIn)
        {
            return new LegendaryItem(quality, sellIn);
        }
        public BackstageItem BackstageItem(int quality, int sellIn)
        {
            return new BackstageItem(quality, sellIn);
        }
        public NormalItem NormalItem(int quality, int sellIn)
        {
            return new NormalItem(quality, sellIn);
        }
    }
}