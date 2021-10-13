namespace Gilded_rose.ItemsFolder
{
    class BrieItem : Item,IItem
    {
        public BrieItem(int quality, int sellIn)
        {
            Quality = quality;
            SellIn = sellIn;
        }

        public void UpdateQuality()
        {
            Quality += (SellIn > 0) ? 1 : 2;
            Quality = (Quality > 50) ? 50 : Quality;
        }

        public void UpdateSellIn()
        {
            SellIn--;
        }

        public int getUpdatedQuality()
        {
            UpdateQuality();
            return Quality;
        }

        public int getUpdatedSellIn()
        {
            UpdateSellIn();
            return SellIn;
        }
    }
}