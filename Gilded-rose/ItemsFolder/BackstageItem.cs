namespace Gilded_rose.ItemsFolder
{
    class BackstageItem : Item, IItem
    {
        public BackstageItem(int quality, int sellIn)
        {
            Quality = quality;
            SellIn = sellIn;
        }

        private void UpdateQuality()
        {
            Quality += (SellIn > 10) ? 1 : 0;
            Quality += (SellIn > 5 && SellIn <= 10) ? 2 : 0;
            Quality += (SellIn > 0 && SellIn <= 5) ? 3 : 0;
            Quality = (SellIn <= 0) ? 0 : Quality;
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