namespace Gilded_rose.ItemsFolder
{
    class BrieItem : Item,IItem
    {
        public BrieItem(int quality, int sellIn)
        {
            Quality = quality;
            SellIn = sellIn;
        }

        private void UpdateQuality()
        {
            Quality += (SellIn > 0) ? 1 : 2;
            Quality = (Quality > 50) ? 50 : Quality;
        }

        private void UpdateSellIn()
        {
            SellIn--;
        }

        public int GetUpdatedQuality()
        {
            UpdateQuality();
            return Quality;
        }

        public int GetUpdatedSellIn()
        {
            UpdateSellIn();
            return SellIn;
        }
    }
}