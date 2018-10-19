using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EX1.Test
{
    [TestClass]
    public class ItemTest
    {
        [TestMethod]
        public void ItemClassToString()
        {
            Junk junk = new Junk(
                        Guid.NewGuid(),
                        "Leather Scraps",
                        null,
                        false,
                        .5f,
                        InventorySlotId.UNEQUIPPABLE,
                        1);
            
            Assert.AreEqual($"{junk.Name}", junk.ToString());
        }
        [TestMethod]
        public void ArmorClassToString()
        {
            Armor junk = new Armor(
                        Guid.NewGuid(),
                        "Leather Scraps",
                        null,
                        false,
                        .5f,
                        InventorySlotId.UNEQUIPPABLE,
                        1,
                        1);
            Assert.AreEqual($"{junk.Name} (+{junk.Def})", junk.ToString());
        }
        [TestMethod]
        public void WeaponClassToString()
        {
            Weapon junk = new Weapon(
                        Guid.NewGuid(),
                        "Leather Scraps",
                        null,
                        false,
                        .5f,
                        InventorySlotId.UNEQUIPPABLE,
                        1,
                        1);
            Assert.AreEqual($"{junk.Name} (+{junk.ATK})", junk.ToString());
        }
        [TestMethod]
        public void PotionClassToString()
        {
            Potion junk = new Potion(
                        Guid.NewGuid(),
                        "Leather Scraps",
                        null,
                        false,
                        .5f,
                        InventorySlotId.UNEQUIPPABLE,
                        1,
                        1);
            Assert.AreEqual($"{junk.Name} (+{junk.HealValue})", junk.ToString());
        }
    }
}
