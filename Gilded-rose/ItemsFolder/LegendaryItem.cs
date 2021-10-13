namespace Gilded_rose.ItemsFolder
{
    class LegendaryItem : Item, IItem
    {
        public LegendaryItem(int itemQuality, int itemSellIn)
        {
            this.Quality = itemQuality;
            this.SellIn = itemSellIn;
        }

        private void UpdateQuality()
        {

        }

        private void UpdateSellIn()
        {
        }

        public int GetUpdatedQuality()
        {
            return Quality;
        }

        public int GetUpdatedSellIn()
        {
            return SellIn;
        }
    }
}