namespace Gilded_rose.ItemsFolder
{
    class ItemFactory : IAbstractFactory
    {
        public IItem createItem(Item item)
        {
            return item.Name switch
            {
                "Aged Brie" => new BrieItem(item.Quality, item.SellIn),
                "Sulfuras, Hand of Ragnaros" => new LegendaryItem(item.Quality, item.SellIn),
                "Backstage passes to a TAFKAL80ETC concert" => new BackstageItem(item.Quality, item.SellIn),
                _ => new NormalItem(item.Quality, item.SellIn)
            };
        }
    }
}