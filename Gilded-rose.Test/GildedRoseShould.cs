using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Gilded_rose;
using NUnit.Framework;

namespace KataGildedRose.Tests
{
    public class GildedRoseShould
    {

        [Test]
        public void decrease_by_one_the_normal_item_quality_and_sellIn()
        {
            IList<Item> Items = new List<Item> {new Item {Name = "Normal item", SellIn = 5, Quality = 2}};
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().Quality.Should().Be(1);
            Items.First().SellIn.Should().Be(4);
        }

        [Test]
        public void dont_decrease_normal_item_quality_below_zero()
        {
            IList<Item> Items = new List<Item> {new Item {Name = "Normal item", SellIn = 5, Quality = 0}};
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().SellIn.Should().Be(4);
            Items.First().Quality.Should().Be(0);
        }

        [Test]
        public void decrease_normal_item_quality_twice_when_sellIn_is_dropped()
        {
            IList<Item> Items = new List<Item> {new Item {Name = "Normal item", SellIn = 0, Quality = 12}};
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().SellIn.Should().Be(-1);
            Items.First().Quality.Should().Be(10);
        }

        [Test]
        public void increase_by_one_the_aged_brie_item_quality()
        {
            IList<Item> Items = new List<Item> {new Item {Name = "Aged Brie", SellIn = 8, Quality = 10}};
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().SellIn.Should().Be(7);
            Items.First().Quality.Should().Be(11);
        }

        [Test]
        public void increase_by_two_when_aged_brie_sellIn_is_dropped()
        {
            IList<Item> Items = new List<Item> {new Item {Name = "Aged Brie", SellIn = 0, Quality = 10}};
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().SellIn.Should().Be(-1);
            Items.First().Quality.Should().Be(12);
        }

        [Test]
        public void increase_by_two_when_aged_brie_quality_and_sellIn_is_in_limit()
        {
            IList<Item> Items = new List<Item> {new Item {Name = "Aged Brie", SellIn = 0, Quality = 49}};
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().SellIn.Should().Be(-1);
            Items.First().Quality.Should().Be(50);
        }

        [Test]
        public void dont_increase_the_quality_above_50()
        {
            IList<Item> Items = new List<Item> {new Item {Name = "Aged Brie", SellIn = 8, Quality = 50}};
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().SellIn.Should().Be(7);
            Items.First().Quality.Should().Be(50);
        }

        [Test]
        public void dont_change_sulfuras_sellIn_and_quality_parameters()
        {
            IList<Item> Items = new List<Item>
                {new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 8, Quality = 80}};
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().SellIn.Should().Be(8);
            Items.First().Quality.Should().Be(80);
        }

        [Test]
        public void increase_backstage_pass_quality_by_two_when_sellIn_is_less_than_ten()
        {
            IList<Item> Items = new List<Item>
                {new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 8, Quality = 30}};
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().SellIn.Should().Be(7);
            Items.First().Quality.Should().Be(32);
        }

        [Test]
        public void increase_backstage_pass_quality_by_three_when_sellIn_is_less_than_five()
        {
            IList<Item> Items = new List<Item>
                {new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 17}};
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().SellIn.Should().Be(3);
            Items.First().Quality.Should().Be(20);
        }

        [Test]
        public void decrease_backstage_pass_quality_to_zero_when_sellIn_is_dropped()
        {
            IList<Item> Items = new List<Item>
                {new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 30}};
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().SellIn.Should().Be(-1);
            Items.First().Quality.Should().Be(0);
        }

        [Test]
        public void increase_by_one_when_sellIn_is_dropped_in_aged_brie()
        {
            IList<Item> Items = new List<Item> {new Item {Name = "Aged Brie", SellIn = 1, Quality = 45}};
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().SellIn.Should().Be(0);
            Items.First().Quality.Should().Be(46);
        }

        [Test]
        public void decrease_twice_as_fast_when_item_is_conjured()
        {
            IList<Item> Items = new List<Item> {new Item {Name = "Conjured", SellIn = 5, Quality = 3}};
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().Quality.Should().Be(1);
            Items.First().SellIn.Should().Be(4);
        }

        [Test]
        public void dont_decrease_conjured_item_quality_below_zero()
        {
            IList<Item> Items = new List<Item> {new Item {Name = "Conjured", SellIn = 5, Quality = 1}};
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().SellIn.Should().Be(4);
            Items.First().Quality.Should().Be(0);
        }

        [Test]
        public void decrease_conjured_item_quality_four_times_when_sellIn_is_dropped()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured", SellIn = -1, Quality = 30 } };
            var app = new GildedRose(Items);

            app.UpdateQuality();

            Items.First().SellIn.Should().Be(-2);
            Items.First().Quality.Should().Be(26);
        }
    }
}