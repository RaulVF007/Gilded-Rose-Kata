namespace Gilded_rose
{
    class LegendaryItem : Item, IItem
    {
        public LegendaryItem(int itemQuality, int itemSellIn)
        {
            this.Quality = itemQuality;
            this.SellIn = itemSellIn;
        }

        public void UpdateQuality()
        {

        }

        public void UpdateSellIn()
        {
        }

        public int getUpdatedQuality()
        {
            return Quality;
        }

        public int getUpdatedSellIn()
        {
            return SellIn;
        }
    }
}