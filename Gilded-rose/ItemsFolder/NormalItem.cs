namespace Gilded_rose.ItemsFolder
{
    class NormalItem : Item, IItem
    {
    public NormalItem(int quality, int sellIn)
    {
        Quality = quality;
        SellIn = sellIn;
    }

    public void UpdateQuality()
    {
        if (SellIn > 0) Quality -= (Quality >= 1) ? 1 : 0;

        if (SellIn == 0)
        {
            Quality -= (Quality >= 2) ? 1 : 0;
            Quality -= (Quality >= 1) ? 1 : 0;
        }

        if (SellIn < 0) Quality -= (Quality > 1) ? 2 : 0;
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