namespace Gilded_rose.ItemsFolder
{
    class NormalItem : Item, IItem
    {
    public NormalItem(int quality, int sellIn)
    {
        Quality = quality;
        SellIn = sellIn;
    }

    private void UpdateQuality()
    {
        if (SellIn > 0) Quality -= (Quality >= 1) ? 1 : 0;

        if (SellIn == 0)
        {
            Quality -= (Quality >= 2) ? 1 : 0;
            Quality -= (Quality >= 1) ? 1 : 0;
        }

        if (SellIn < 0) Quality -= (Quality > 1) ? 2 : 0;
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