using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EX1;

namespace EX1.Test
{
    [TestClass]
    public class BagTest
    {
        private Bag CreateBag3()
        {
            Bag bag = new Bag(20.0f);
            Junk junk = new Junk(
                        Guid.NewGuid(),
                        "Leather Scraps",
                        null,
                        false,
                        .5f,
                        InventorySlotId.UNEQUIPPABLE,
                        1);
            Junk junk1 = new Junk(
                        Guid.NewGuid(),
                        "Iron Dust",
                        null,
                        false,
                        1f,
                        InventorySlotId.UNEQUIPPABLE,
                        5);
            Junk junk2 = new Junk(
                        Guid.NewGuid(),
                        "Rotten Flesh",
                        null,
                        false,
                        1f,
                        InventorySlotId.UNEQUIPPABLE,
                        1);
            bag.Add(junk);
            bag.Add(junk1);
            bag.Add(junk2);
            return bag;
        }

        [TestMethod]
        public void Enumerate()
        {
            IEnumerable<Item> bag = CreateBag3();

            //var items = bag.GetEnumerator();
            //Assert.AreEqual(true, items.MoveNext());
            //Assert.AreEqual(true, items.MoveNext());
            //Assert.AreEqual(true, items.MoveNext());
            //Assert.AreEqual(false, items.MoveNext());

            //var itr = bag.GetEnumerator();
            //while (itr.MoveNext())
            //{
            //    Item i = itr.Current;
            //}

            int count = 0;
            foreach (Item i in bag)
            {
                ++count;
            }
            Assert.AreEqual(3, count);
        }

        [TestMethod]
        public void ItemRemovedAtIndex()
        {
            Bag bag = CreateBag3();
            Item junk1 = bag[1];

            Item removed = bag.RemoveAt(1);
            Assert.AreSame(junk1, removed);
        }
        [TestMethod]
        public void ItemRemovedById()
        {
            Bag bag = CreateBag3();
            Item junk1 = bag[1];

            Item removed = bag.RemoveById(junk1.Id);
            Assert.AreSame(junk1, removed);
        }
    }
}
