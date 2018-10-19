using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EX1.Test
{
    [TestClass]
    public class EquippedItemsTest
    {
        //internal enum InventorySloId
        //{
        //    UNEQUIPPABLE = 0,
        //    HELMET = 1,
        //    VEST = 2,
        //    WEAPON = 3,
        //    POTION = 4
        //}
        //private Bag CreateBag3()
        //{
        //    Bag bag = new Bag(20.0f);
        //    Armor junk = new Armor(
        //                Guid.NewGuid(),
        //                "Leather Scraps",
        //                null,
        //                false,
        //                .5f,
        //                InventorySlotId.UNEQUIPPABLE,
        //                1,
        //                1);
        //    Armor junk1 = new Armor(
        //                Guid.NewGuid(),
        //                "Iron Dust",
        //                null,
        //                false,
        //                1f,
        //                InventorySlotId.UNEQUIPPABLE,
        //                5,
        //                1);
        //    Weapon junk2 = new Weapon(
        //                Guid.NewGuid(),
        //                "Rotten Flesh",
        //                null,
        //                false,
        //                1f,
        //                InventorySlotId.UNEQUIPPABLE,
        //                1,
        //                1);
        //    Potion junk3 = new Potion(
        //                Guid.NewGuid(),
        //                "Rotten Flesh",
        //                null,
        //                false,
        //                1f,
        //                InventorySlotId.UNEQUIPPABLE,
        //                1,
        //                1);
        //    bag.Add(junk);
        //    bag.Add(junk1);
        //    bag.Add(junk2);
        //    bag.Add(junk3);
        //    return bag;
        //}
        //private Character CreateCharacter()
        //{
        //    Character bob = new Character("bob", 1, 1, 1);
        //    return bob;
        //}

        [TestMethod]
        public void EquipItem()
        {
            //Character bob = CreateCharacter();
            //Bag b = CreateBag3();
            //Dictionary<InventorySlotId, Item> _items = new Dictionary<InventorySlotId, Item>();
            //bob.Bag.

            var equipped = new EquippedItems();
            Armor junk = new Armor(
                            Guid.NewGuid(),
                            "Leather Scraps",
                            null,
                            false,
                            .5f,
                            InventorySlotId.UNEQUIPPABLE,
                            1,
                            1);
            Assert.IsNull(equipped[InventorySlotId.HELMET]);

            equipped.Equip(InventorySlotId.HELMET, junk);
            Assert.AreEqual(junk, equipped[InventorySlotId.HELMET]);


        }
        [TestMethod]
        public void UnEquipItem()
        {
            //Character bob = CreateCharacter();
            //Bag b = CreateBag3();
            //Dictionary<InventorySlotId, Item> _items = new Dictionary<InventorySlotId, Item>();
            //bob.Bag.

            var equipped = new EquippedItems();
            Armor junk = new Armor(
                            Guid.NewGuid(),
                            "Leather Scraps",
                            null,
                            false,
                            .5f,
                            InventorySlotId.UNEQUIPPABLE,
                            1,
                            1);
            Assert.IsNull(equipped[InventorySlotId.HELMET]);

            equipped.Equip(InventorySlotId.HELMET, junk);
            Assert.AreEqual(junk, equipped[InventorySlotId.HELMET]);
            equipped.Unequip(InventorySlotId.HELMET);
            Assert.AreEqual(null, equipped[InventorySlotId.HELMET]);


        }
    }
}
