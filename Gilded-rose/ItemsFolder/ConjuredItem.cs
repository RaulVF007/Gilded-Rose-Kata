using System;
using System.Collections.Generic;
using System.Text;

namespace Gilded_rose.ItemsFolder
{
    class ConjuredItem : Item, IItem
    {
        public ConjuredItem(int itemQuality, int itemSellIn)
        {
            Quality = itemQuality;
            SellIn = itemSellIn;
        }

        private void UpdateQuality()
        {
            if (SellIn > 0) Quality -= (Quality >= 2) ? 2 : 0;

            if (SellIn == 0)
            {
                Quality -= (Quality >= 2) ? 2 : 0;
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
