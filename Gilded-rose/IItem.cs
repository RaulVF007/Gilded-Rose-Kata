namespace Gilded_rose
{
    internal interface IItem
    {
        void UpdateQuality();
        void UpdateSellIn();

        int getUpdatedQuality();
        int getUpdatedSellIn();
    }
}