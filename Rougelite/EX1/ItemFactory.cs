using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EX1
{
    public class ItemFactory
    {
        private Random _rand = new Random();

        public ItemFactory()
        {

        }
        public bool RollForDoomGear()
        {
            return _rand.Next(1, 21) == 1;
        }

        #region Spawning DOOM Gear
        public Armor SpawnDoomHelmet()
        { 
            return new Armor(
                Guid.NewGuid(),
                "Alan's Unicorn Helmet of DOOM", 
                Properties.Resources.Alan_s_Unicorn_Helmet_of_DOOM,
                false,
                2,
                InventorySlotId.HELMET,
                500,
                500);
        }
        public Armor SpawnDoomVest()
        {
            return new Armor(
                Guid.NewGuid(),
                "Alan's Unicorn Vest of DOOM", 
                Properties.Resources.Alan_s_Unicorn_Vest_of_DOOM, 
                false,
                10,
                InventorySlotId.VEST,
                1000,
                1000);
        }
        public Weapon SpawnDoomBlade()
        {
            return new Weapon(
                Guid.NewGuid(),
                "Alan's Unicorn Blade of DOOM", 
                Properties.Resources.Alan_s_Unicorn_Blade_of_DOOM, 
                false,
                10,
                InventorySlotId.WEAPON,
                9000,
                9000);
        }
        #endregion

        //Spawning Hero Gear
        public Armor SpawnHelmet()
        {
            switch (_rand.Next(1, 6))
            {
                case 1:
                    return new Armor(
                        Guid.NewGuid(),
                        "Scaled Helmet of Burning Fortunes",
                        Properties.Resources.Scaled_Helmet_of_Burning_Fortunes,
                        false,
                        3.3f,
                        InventorySlotId.HELMET,
                        30,
                        _rand.Next(6, 16));
                case 2:
                    return new Armor(
                        Guid.NewGuid(),
                        "Terror Iron Helm",
                        Properties.Resources.Terror_Iron_Helm,
                        false,
                        3.2f,
                        InventorySlotId.HELMET,
                        35,
                        _rand.Next(6, 16));
                case 3:
                    return new Armor(
                        Guid.NewGuid(),
                        "Helm of Haunted Dreams",
                        Properties.Resources.Helm_of_Haunted_Dreams,
                        false,
                        2.9f,
                        InventorySlotId.HELMET,
                        20,
                        _rand.Next(6, 16));
                case 4:
                    return new Armor(
                        Guid.NewGuid(),
                        "Scaled Hood of Demonic visions",
                        Properties.Resources.Scaled_Hood_of_Demonic_visions,
                        false,
                        2.1f,
                        InventorySlotId.HELMET,
                        15,
                        _rand.Next(6, 16));
                case 5:
                    return new Armor(
                        Guid.NewGuid(),
                        "The Ultimate Helm of Destruction(Spikey)",
                        Properties.Resources.The_Ultimate_Helm_of_Destruction_Spikey_,
                        false,
                        3.9f,
                        InventorySlotId.HELMET,
                        40,
                        _rand.Next(6, 16));
                default:
                    throw new Exception();
            }
        }
        public Armor SpawnVest()
        {
            switch (_rand.Next(1, 6))
            {
                case 1:
                    return new Armor(
                        Guid.NewGuid(),
                        "ThunderGuard Iron Chestplate",
                        Properties.Resources.ThunderGuard_Iron_Chestplate,
                        false,
                        10.8f,
                        InventorySlotId.VEST,
                        40,
                        _rand.Next(10, 21));
                case 2:
                    return new Armor(
                        Guid.NewGuid(),
                        "Greatplate of Fleeting Punishment",
                        Properties.Resources.Greatplate_of_Fleeting_Punishment,
                        false,
                        12.4f,
                        InventorySlotId.VEST,
                        43,
                        _rand.Next(10, 21));
                case 3:
                    return new Armor(
                        Guid.NewGuid(),
                        "Chestpiece of Ending Bloodlust",
                        Properties.Resources.Chestpiece_of_Ending_Bloodlust,
                        false,
                        13.7f,
                        InventorySlotId.VEST,
                        48,
                        _rand.Next(10, 21));
                case 4:
                    return new Armor(
                        Guid.NewGuid(),
                        "Stormguard Bronze Vest",
                        Properties.Resources.Stormguard_Bronze_Vest,
                        false,
                        10.6f,
                        InventorySlotId.VEST,
                        41,
                        _rand.Next(10, 21));
                case 5:
                    return new Armor(
                        Guid.NewGuid(),
                        "Breastplate of Shattered Hope",
                        Properties.Resources.Breastplate_of_Shattered_Hope,
                        false,
                        11f,
                        InventorySlotId.VEST,
                        35,
                        _rand.Next(10, 21));
                default:
                    throw new Exception();
            }
        }
        public Weapon SpawnWeapon()
        {
            switch (_rand.Next(1, 6))
            {
                case 1:
                    return new Weapon(
                        Guid.NewGuid(),
                        "Armageddon, Razor of Hate",
                        Properties.Resources.Armageddon__Razor_of_Hate,
                        false,
                        15.7f,
                        InventorySlotId.WEAPON,
                        53,
                        _rand.Next(45, 66));
                case 2:
                    return new Weapon(
                        Guid.NewGuid(),
                        "Solitude's Warblade",
                        Properties.Resources.Solitude_s_Warblade,
                        false,
                        15.3f,
                        InventorySlotId.WEAPON,
                        56,
                        _rand.Next(45, 66));
                case 3:
                    return new Weapon(
                        Guid.NewGuid(),
                        "Blade of the grave",
                        Properties.Resources.Blade_of_the_grave,
                        false,
                        16.3f,
                        InventorySlotId.WEAPON,
                        59,
                        _rand.Next(45, 66));
                case 4:
                    return new Weapon(
                        Guid.NewGuid(),
                        "Spectral Forged Slicer",
                        Properties.Resources.Spectral_Forged_Slicer,
                        false,
                        15.4f,
                        InventorySlotId.WEAPON,
                        58,
                        _rand.Next(45, 66));
                case 5:
                    return new Weapon(
                        Guid.NewGuid(),
                        "Blood Infused Mithril Carver",
                        Properties.Resources.Blood_Infused_Mithril_Carver,
                        false,
                        16.1f,
                        InventorySlotId.WEAPON,
                        63,
                        _rand.Next(45, 66));
                default:
                    throw new Exception();
            }
        }
        public Potion SpawnPotion()
        {
            switch (_rand.Next(1, 6))
            {
                case 1:
                    return new Potion(
                        Guid.NewGuid(),
                        "Potion of Lesser Healing",
                        Properties.Resources.Potion_of_Lesser_Healing,
                        false,
                        2.1f,
                        InventorySlotId.POTION,
                        50,
                        _rand.Next(1, 11) + 10);
                case 2:
                    return new Potion(
                        Guid.NewGuid(),
                        "Potion of Healing",
                        Properties.Resources.Potion_of_Healing,
                        false,
                        2.2f,
                        InventorySlotId.POTION,
                        60,
                        _rand.Next(1, 21) + 20);
                case 3:
                    return new Potion(
                        Guid.NewGuid(),
                        "Potion of Greater Healing",
                        Properties.Resources.Potion_of_Greater_Healing,
                        false,
                        2.3f,
                        InventorySlotId.POTION,
                        100,
                        _rand.Next(10, 31) + 30);
                case 4:
                    return new Potion(
                        Guid.NewGuid(),
                        "Potion of Legendary Healing",
                        Properties.Resources.Potion_of_Legendary_Healing,
                        false,
                        2.4f,
                        InventorySlotId.POTION,
                        200,
                        _rand.Next(20, 61) + 40);
                case 5:
                    return new Potion(
                        Guid.NewGuid(),
                        "Unicorn Blood",
                        Properties.Resources.Unicorn_Blood,
                        false,
                        1f,
                        InventorySlotId.POTION,
                        500,
                        200);
                default:
                    throw new Exception();
            }
        }
        //Spawning Enemy Gear
        public Armor SpawnStage1EnemyHelmet()
        {
            return null;
        }
        public Armor SpawnStage2EnemyHelmet()
        {
            switch(_rand.Next(1, 6))
            {
                case 1:
                    return new Armor(
                        Guid.NewGuid(),
                        "Amorphous Hood",
                        Properties.Resources.Amorphous_Hood,
                        false,
                        3.3f,
                        InventorySlotId.HELMET,
                        30,
                        _rand.Next(6, 16));
                case 2:
                    return new Armor(
                        Guid.NewGuid(),
                        "Chain Mail Helmet",
                        Properties.Resources.Chain_Male_Helmet,
                        false,
                        3.2f,
                        InventorySlotId.HELMET,
                        35,
                        _rand.Next(6, 16));
                case 3:
                    return new Armor(
                        Guid.NewGuid(),
                        "Gladiator Helmet",
                        Properties.Resources.Gladiator_Helmet,
                        false,
                        2.9f,
                        InventorySlotId.HELMET,
                        20,
                        _rand.Next(6, 16));
                case 4:
                    return new Armor(
                        Guid.NewGuid(),
                        "Helm of Anubis",
                        Properties.Resources.Helm_of_Anubis,
                        false,
                        2.1f,
                        InventorySlotId.HELMET,
                        15,
                        _rand.Next(6, 16));
                case 5:
                    return new Armor(
                        Guid.NewGuid(),
                        "Helm of Fire",
                        Properties.Resources.Helm_of_Fire,
                        false,
                        3.9f,
                        InventorySlotId.HELMET,
                        40,
                        _rand.Next(6, 16));
                default:
                    throw new Exception();
            }
        }
        public Armor SpawnStage3EnemyHelmet()
        {
            return null;
        }
        public Armor SpawnStage4EnemyHelmet()
        {
            switch (_rand.Next(1, 6))
            {
                case 1:
                    return new Armor(
                        Guid.NewGuid(),
                        "Helm of Rage",
                        Properties.Resources.Helm_of_Rage,
                        false,
                        3.3f,
                        InventorySlotId.HELMET,
                        30,
                        _rand.Next(6, 16));
                case 2:
                    return new Armor(
                        Guid.NewGuid(),
                        "Helm of Sauron",
                        Properties.Resources.Helm_of_Sauron,
                        false,
                        3.2f,
                        InventorySlotId.HELMET,
                        35,
                        _rand.Next(6, 16));
                case 3:
                    return new Armor(
                        Guid.NewGuid(),
                        "Diseased Helm",
                        Properties.Resources.Helm_of_Sickness,
                        false,
                        2.9f,
                        InventorySlotId.HELMET,
                        20,
                        _rand.Next(6, 16));
                case 4:
                    return new Armor(
                        Guid.NewGuid(),
                        "Helm of Troy",
                        Properties.Resources.Helm_of_Troy,
                        false,
                        2.1f,
                        InventorySlotId.HELMET,
                        15,
                        _rand.Next(6, 16));
                case 5:
                    return new Armor(
                        Guid.NewGuid(),
                        "Helmet of Darkness",
                        Properties.Resources.Helmet_of_Darkness,
                        false,
                        3.9f,
                        InventorySlotId.HELMET,
                        40,
                        _rand.Next(6, 16));
                default:
                    throw new Exception();
            }
        }
        public Armor SpawnStage5EnemyHelmet()
        {
            switch (_rand.Next(1, 6))
            {
                case 1:
                    return new Armor(
                        Guid.NewGuid(),
                        "Horned Helm",
                        Properties.Resources.Horned_Helm,
                        false,
                        3.3f,
                        InventorySlotId.HELMET,
                        30,
                        _rand.Next(6, 16));
                case 2:
                    return new Armor(
                        Guid.NewGuid(),
                        "Jeweled Frost",
                        Properties.Resources.Jeweled_Frost,
                        false,
                        3.2f,
                        InventorySlotId.HELMET,
                        35,
                        _rand.Next(6, 16));
                case 3:
                    return new Armor(
                        Guid.NewGuid(),
                        "Poison Death",
                        Properties.Resources.Poison_Death,
                        false,
                        2.9f,
                        InventorySlotId.HELMET,
                        20,
                        _rand.Next(6, 16));
                case 4:
                    return new Armor(
                        Guid.NewGuid(),
                        "Skeletal Helmet",
                        Properties.Resources.Skeletal_Helmet,
                        false,
                        2.1f,
                        InventorySlotId.HELMET,
                        15,
                        _rand.Next(6, 16));
                case 5:
                    return new Armor(
                        Guid.NewGuid(),
                        "Winged Fury",
                        Properties.Resources.Winged_Fury,
                        false,
                        3.9f,
                        InventorySlotId.HELMET,
                        40,
                        _rand.Next(6, 16));
                default:
                    throw new Exception();
            }
        }
        public Armor SpawnStage1EnemyVest()
        {
            switch (_rand.Next(1, 6))
            {
                case 1:
                    return new Armor(
                        Guid.NewGuid(),
                        "Black Hide",
                        Properties.Resources.Black_Hide,
                        true,
                        3.3f,
                        InventorySlotId.VEST,
                        35,
                        _rand.Next(10, 21));
                case 2:
                    return new Armor(
                        Guid.NewGuid(),
                        "Brown Hide",
                        Properties.Resources.Brown_Hide,
                        true,
                        3.2f,
                        InventorySlotId.VEST,
                        40,
                        _rand.Next(10, 21));
                case 3:
                    return new Armor(
                        Guid.NewGuid(),
                        "Grey Hide",
                        Properties.Resources.Grey_Hide,
                        true,
                        2.9f,
                        InventorySlotId.VEST,
                        25,
                        _rand.Next(10, 21));
                case 4:
                    return new Armor(
                        Guid.NewGuid(),
                        "Rippled Hide",
                        Properties.Resources.Rippled_Hide,
                        true,
                        2.1f,
                        InventorySlotId.VEST,
                        20,
                        _rand.Next(10, 21));
                case 5:
                    return new Armor(
                        Guid.NewGuid(),
                        "White Hide",
                        Properties.Resources.White_Hide,
                        true,
                        3.9f,
                        InventorySlotId.VEST,
                        45,
                        _rand.Next(10, 21));
                default:
                    throw new Exception();
            }
        }
        public Armor SpawnStage2EnemyVest()
        {
            switch (_rand.Next(1, 6))
            {
                case 1:
                    return new Armor(
                        Guid.NewGuid(),
                        "Armor of Agathas",
                        Properties.Resources.Armor_of_Agathas,
                        false,
                        10.8f,
                        InventorySlotId.VEST,
                        40,
                        _rand.Next(10, 21));
                case 2:
                    return new Armor(
                        Guid.NewGuid(),
                        "Armor of Evil",
                        Properties.Resources.Armor_of_Evil,
                        false,
                        12.4f,
                        InventorySlotId.VEST,
                        43,
                        _rand.Next(10, 21));
                case 3:
                    return new Armor(
                        Guid.NewGuid(),
                        "Armor of Shadows",
                        Properties.Resources.Armor_of_Shadows,
                        false,
                        13.7f,
                        InventorySlotId.VEST,
                        48,
                        _rand.Next(10, 21));
                case 4:
                    return new Armor(
                        Guid.NewGuid(),
                        "Chest Plate of Anubis",
                        Properties.Resources.Chest_Plate_of_Anubis,
                        false,
                        10.6f,
                        InventorySlotId.VEST,
                        41,
                        _rand.Next(10, 21));
                case 5:
                    return new Armor(
                        Guid.NewGuid(),
                        "Dragon Plate Armor",
                        Properties.Resources.Dragon_Plate_Armor,
                        false,
                        11f,
                        InventorySlotId.VEST,
                        35,
                        _rand.Next(10, 21));
                default:
                    throw new Exception();
            }
        }
        public Armor SpawnStage3EnemyVest()
        {
            return null;
        }
        public Armor SpawnStage4EnemyVest()
        {
            switch (_rand.Next(1, 6))
            {
                case 1:
                    return new Armor(
                        Guid.NewGuid(),
                        "Felix Rogue Armor",
                        Properties.Resources.Felix_Rogue_Armor,
                        false,
                        10.8f,
                        InventorySlotId.VEST,
                        45,
                        _rand.Next(10, 21));
                case 2:
                    return new Armor(
                        Guid.NewGuid(),
                        "Iron Vest",
                        Properties.Resources.Iron_Vest,
                        false,
                        12.4f,
                        InventorySlotId.VEST,
                        48,
                        _rand.Next(10, 21));
                case 3:
                    return new Armor(
                        Guid.NewGuid(),
                        "Jerken of Ice",
                        Properties.Resources.Jerken_of_Ice,
                        false,
                        13.7f,
                        InventorySlotId.VEST,
                        53,
                        _rand.Next(10, 21));
                case 4:
                    return new Armor(
                        Guid.NewGuid(),
                        "Kunoichi Chest Guard",
                        Properties.Resources.Kunoichi_Chest_Guard,
                        false,
                        10.6f,
                        InventorySlotId.VEST,
                        46,
                        _rand.Next(10, 21));
                case 5:
                    return new Armor(
                        Guid.NewGuid(),
                        "Legion Armor",
                        Properties.Resources.Legion_Armor,
                        false,
                        11f,
                        InventorySlotId.VEST,
                        40,
                        _rand.Next(10, 21));
                default:
                    throw new Exception();
            }
        }
        public Armor SpawnStage5EnemyVest()
        {
            switch (_rand.Next(1, 6))
            {
                case 1:
                    return new Armor(
                        Guid.NewGuid(),
                        "Red Guard Armor",
                        Properties.Resources.Red_Guard_Armor,
                        false,
                        10.8f,
                        InventorySlotId.VEST,
                        50,
                        _rand.Next(10, 21));
                case 2:
                    return new Armor(
                        Guid.NewGuid(),
                        "Rusty Bronze Breast Plate",
                        Properties.Resources.Rusty_Bronze_Breast_Plate,
                        false,
                        12.4f,
                        InventorySlotId.VEST,
                        53,
                        _rand.Next(10, 21));
                case 3:
                    return new Armor(
                        Guid.NewGuid(),
                        "Scaled Breast Plate",
                        Properties.Resources.Scaled_Breast_Plate,
                        false,
                        13.7f,
                        InventorySlotId.VEST,
                        58,
                        _rand.Next(10, 21));
                case 4:
                    return new Armor(
                        Guid.NewGuid(),
                        "Viscious Breast Plate",
                        Properties.Resources.Viscious_Breast_Plate,
                        false,
                        10.6f,
                        InventorySlotId.VEST,
                        51,
                        _rand.Next(10, 21));
                case 5:
                    return new Armor(
                        Guid.NewGuid(),
                        "Wooden Chest Plate",
                        Properties.Resources.Wooden_Chest_Plate,
                        false,
                        11f,
                        InventorySlotId.VEST,
                        45,
                        _rand.Next(10, 21));
                default:
                    throw new Exception();
            }
        }
        public Weapon SpawnStage1EnemyWeapon()
        {
            switch (_rand.Next(1, 7))
            {
                case 1:
                    return new Weapon(
                        Guid.NewGuid(),
                        "Bludgeoning Claws",
                        Properties.Resources.Bludgeoning_Claws,
                        true,
                        3.3f,
                        InventorySlotId.HELMET,
                        30,
                        _rand.Next(45, 66));
                case 2:
                    return new Weapon(
                        Guid.NewGuid(),
                        "Puncturing Claws",
                        Properties.Resources.Puncturing_Claws,
                        true,
                        3.2f,
                        InventorySlotId.HELMET,
                        35,
                        _rand.Next(45, 66));
                case 3:
                    return new Weapon(
                        Guid.NewGuid(),
                        "Slashing Claws",
                        Properties.Resources.Slashing_Claws,
                        true,
                        2.9f,
                        InventorySlotId.HELMET,
                        20,
                        _rand.Next(45, 66));
                case 4:
                    return new Weapon(
                        Guid.NewGuid(),
                        "Puncturing Fangs",
                        Properties.Resources.Puncturing_Fangs,
                        true,
                        2.1f,
                        InventorySlotId.HELMET,
                        15,
                        _rand.Next(45, 66));
                case 5:
                    return new Weapon(
                        Guid.NewGuid(),
                        "Tearing Fangs",
                        Properties.Resources.Tearing_Fangs,
                        true,
                        3.9f,
                        InventorySlotId.HELMET,
                        40,
                        _rand.Next(45, 66));
                case 6:
                    return new Weapon(
                        Guid.NewGuid(),
                        "Venomous Fangs",
                        Properties.Resources.Venomous_Fangs,
                        true,
                        3.9f,
                        InventorySlotId.HELMET,
                        40,
                        _rand.Next(45, 66));
                default:
                    throw new Exception();
            }
        }
        public Weapon SpawnStage2EnemyWeapon()
        {
            switch (_rand.Next(1, 6))
            {
                case 1:
                    return new Weapon(
                        Guid.NewGuid(),
                        "Assassin's Sword",
                        Properties.Resources.Assassins_Sword,
                        false,
                        15.7f,
                        InventorySlotId.WEAPON,
                        53,
                        _rand.Next(45, 66));
                case 2:
                    return new Weapon(
                        Guid.NewGuid(),
                        "Blade of Souls",
                        Properties.Resources.Blade_of_Souls,
                        false,
                        15.3f,
                        InventorySlotId.WEAPON,
                        56,
                        _rand.Next(45, 66));
                case 3:
                    return new Weapon(
                        Guid.NewGuid(),
                        "Blade of the Raven Queen",
                        Properties.Resources.Blade_of_the_Raven_Queen,
                        false,
                        16.3f,
                        InventorySlotId.WEAPON,
                        59,
                        _rand.Next(45, 66));
                case 4:
                    return new Weapon(
                        Guid.NewGuid(),
                        "Blade of the Willow Wisp",
                        Properties.Resources.Blade_of_the_Willow_Wisp,
                        false,
                        15.4f,
                        InventorySlotId.WEAPON,
                        58,
                        _rand.Next(45, 66));
                case 5:
                    return new Weapon(
                        Guid.NewGuid(),
                        "Demon Blood Dagger",
                        Properties.Resources.Demon_Blood_Dagger,
                        false,
                        16.1f,
                        InventorySlotId.WEAPON,
                        63,
                        _rand.Next(45, 66));
                default:
                    throw new Exception();
            }
        }
        public Weapon SpawnStage3EnemyWeapon()
        {
            switch (_rand.Next(1, 6))
            {
                case 1:
                    return new Weapon(
                        Guid.NewGuid(),
                        "Fist of Fire",
                        Properties.Resources.Fist_of_Fire,
                        true,
                        3.3f,
                        InventorySlotId.HELMET,
                        30,
                        _rand.Next(45, 66));
                case 2:
                    return new Weapon(
                        Guid.NewGuid(),
                        "Fist of Ice",
                        Properties.Resources.Fist_of_Ice,
                        true,
                        3.2f,
                        InventorySlotId.HELMET,
                        35,
                        _rand.Next(45, 66));
                case 3:
                    return new Weapon(
                        Guid.NewGuid(),
                        "Fist of Shadow",
                        Properties.Resources.Fist_of_Shadow,
                        true,
                        2.9f,
                        InventorySlotId.HELMET,
                        20,
                        _rand.Next(45, 66));
                case 4:
                    return new Weapon(
                        Guid.NewGuid(),
                        "Fist of Wind",
                        Properties.Resources.Fist_of_Wind,
                        true,
                        2.1f,
                        InventorySlotId.HELMET,
                        15,
                        _rand.Next(45, 66));
                case 5:
                    return new Weapon(
                        Guid.NewGuid(),
                        "Fist of Water",
                        Properties.Resources.Fist_of_Water,
                        true,
                        3.9f,
                        InventorySlotId.HELMET,
                        40,
                        _rand.Next(45, 66));
                default:
                    throw new Exception();
            }
        }
        public Weapon SpawnStage4EnemyWeapon()
        {
            switch (_rand.Next(1, 6))
            {
                case 1:
                    return new Weapon(
                        Guid.NewGuid(),
                        "Executioner's Great Sword",
                        Properties.Resources.Executioner_s_GreatSword,
                        false,
                        15.7f,
                        InventorySlotId.WEAPON,
                        53,
                        _rand.Next(45, 66));
                case 2:
                    return new Weapon(
                        Guid.NewGuid(),
                        "Hassassin Dagger",
                        Properties.Resources.Hassassin_Dagger,
                        false,
                        15.3f,
                        InventorySlotId.WEAPON,
                        56,
                        _rand.Next(45, 66));
                case 3:
                    return new Weapon(
                        Guid.NewGuid(),
                        "Infested DeathBringer",
                        Properties.Resources.Infested_DeathBringer,
                        false,
                        16.3f,
                        InventorySlotId.WEAPON,
                        59,
                        _rand.Next(45, 66));
                case 4:
                    return new Weapon(
                        Guid.NewGuid(),
                        "NightBringer",
                        Properties.Resources.NightBringer,
                        false,
                        15.4f,
                        InventorySlotId.WEAPON,
                        58,
                        _rand.Next(45, 66));
                case 5:
                    return new Weapon(
                        Guid.NewGuid(),
                        "Pearl Crested Blade",
                        Properties.Resources.Pearl_Crested_Blade,
                        false,
                        16.1f,
                        InventorySlotId.WEAPON,
                        63,
                        _rand.Next(45, 66));
                default:
                    throw new Exception();
            }
        }
        public Weapon SpawnStage5EnemyWeapon()
        {
            switch (_rand.Next(1, 6))
            {
                case 1:
                    return new Weapon(
                        Guid.NewGuid(),
                        "Steel Katana",
                        Properties.Resources.Steel_Katana,
                        false,
                        15.7f,
                        InventorySlotId.WEAPON,
                        53,
                        _rand.Next(45, 66));
                case 2:
                    return new Weapon(
                        Guid.NewGuid(),
                        "Steel Sword",
                        Properties.Resources.Steel_Sword,
                        false,
                        15.3f,
                        InventorySlotId.WEAPON,
                        56,
                        _rand.Next(45, 66));
                case 3:
                    return new Weapon(
                        Guid.NewGuid(),
                        "Sword of Fury",
                        Properties.Resources.Sword_of_Fury,
                        false,
                        16.3f,
                        InventorySlotId.WEAPON,
                        59,
                        _rand.Next(45, 66));
                case 4:
                    return new Weapon(
                        Guid.NewGuid(),
                        "Sword of Sealing",
                        Properties.Resources.Sword_of_Sealing,
                        false,
                        15.4f,
                        InventorySlotId.WEAPON,
                        58,
                        _rand.Next(45, 66));
                case 5:
                    return new Weapon(
                        Guid.NewGuid(),
                        "Sword of Shadows",
                        Properties.Resources.Sword_of_Shadows,
                        false,
                        16.1f,
                        InventorySlotId.WEAPON,
                        63,
                        _rand.Next(45, 66));
                default:
                    throw new Exception();
            }
        }
        //Spawning Junk
        public Junk SpawnJunk()
        {
            switch (_rand.Next(1, 21))
            {
                case 1:
                    return new Junk(
                        Guid.NewGuid(),
                        "Leather Scraps",
                        Properties.Resources.Leather_Scraps,
                        false,
                        .5f,
                        InventorySlotId.UNEQUIPPABLE,
                        1);
                case 2:
                    return new Junk(
                        Guid.NewGuid(),
                        "Leather Straps",
                        Properties.Resources.Leather_Straps,
                        false,
                        .5f,
                        InventorySlotId.UNEQUIPPABLE,
                        2);
                case 3:
                    return new Junk(
                        Guid.NewGuid(),
                        "Iron Ingot",
                        Properties.Resources.Iron_Ingot,
                        false,
                        3f,
                        InventorySlotId.UNEQUIPPABLE,
                        10);
                case 4:
                    return new Junk(
                        Guid.NewGuid(),
                        "Iron Dust",
                        Properties.Resources.Iron_Dust,
                        false,
                        1f,
                        InventorySlotId.UNEQUIPPABLE,
                        5);
                case 5:
                    return new Junk(
                        Guid.NewGuid(),
                        "Unknown Metal",
                        Properties.Resources.Unknown_Metal,
                        false,
                        2f,
                        InventorySlotId.UNEQUIPPABLE,
                        2);
                case 6:
                    return new Junk(
                        Guid.NewGuid(),
                        "Rotten Flesh",
                        Properties.Resources.Rotten_Flesh,
                        false,
                        1f,
                        InventorySlotId.UNEQUIPPABLE,
                        1);
                case 7:
                    return new Junk(
                        Guid.NewGuid(),
                        "Refined Cloth",
                        Properties.Resources.Refined_Cloth,
                        false,
                        .8f,
                        InventorySlotId.UNEQUIPPABLE,
                        5);
                case 8:
                    return new Junk(
                        Guid.NewGuid(),
                        "Silk Blouse",
                        Properties.Resources.Silk_Blouse,
                        false,
                        .6f,
                        InventorySlotId.UNEQUIPPABLE,
                        8);
                case 9:
                    return new Junk(
                        Guid.NewGuid(),
                        "Shredded Fur",
                        Properties.Resources.Shredded_Fur,
                        false,
                        1f,
                        InventorySlotId.UNEQUIPPABLE,
                        4);
                case 10:
                    return new Junk(
                        Guid.NewGuid(),
                        "Vile of Blood",
                        Properties.Resources.Vile_of_Blood,
                        false,
                        1f,
                        InventorySlotId.UNEQUIPPABLE,
                        2);
                case 11:
                    return new Junk(
                        Guid.NewGuid(),
                        "Black Quil",
                        Properties.Resources.Black_Quil,
                        false,
                        .2f,
                        InventorySlotId.UNEQUIPPABLE,
                        2);
                case 12:
                    return new Junk(
                        Guid.NewGuid(),
                        "Jar of Ink",
                        Properties.Resources.Jar_of_Ink,
                        false,
                        .5f,
                        InventorySlotId.UNEQUIPPABLE,
                        2);
                case 13:
                    return new Junk(
                        Guid.NewGuid(),
                        "Sheets of Parchment",
                        Properties.Resources.Sheets_of_Parchment,
                        false,
                        .5f,
                        InventorySlotId.UNEQUIPPABLE,
                        3);
                case 14:
                    return new Junk(
                        Guid.NewGuid(),
                        "Burnt Parchment",
                        Properties.Resources.Burnt_Parchment,
                        false,
                        .3f,
                        InventorySlotId.UNEQUIPPABLE,
                        1);
                case 15:
                    return new Junk(
                        Guid.NewGuid(),
                        "Shattered Iron Jerken",
                        Properties.Resources.Shattered_Iron_Jerken,
                        false,
                        5f,
                        InventorySlotId.UNEQUIPPABLE,
                        5);
                case 16:
                    return new Junk(
                        Guid.NewGuid(),
                        "Torn Leather Bracers",
                        Properties.Resources.Torn_Leather_Bracers,
                        false,
                        2f,
                        InventorySlotId.UNEQUIPPABLE,
                        4);
                case 17:
                    return new Junk(
                        Guid.NewGuid(),
                        "Ripped Leather Pants",
                        Properties.Resources.Ripped_Leather_Pants,
                        false,
                        1.2f,
                        InventorySlotId.UNEQUIPPABLE,
                        6);
                case 18:
                    return new Junk(
                        Guid.NewGuid(),
                        "Mystical Glowing Rock",
                        Properties.Resources.Mystical_Glowing_Rock,
                        false,
                        2f,
                        InventorySlotId.UNEQUIPPABLE,
                        8);
                case 19:
                    return new Junk(
                        Guid.NewGuid(),
                        "Blood Stained Cloth Strips",
                        Properties.Resources.Blood_Stained_Cloth_Strips,
                        false,
                        .6f,
                        InventorySlotId.UNEQUIPPABLE,
                        1);
                case 20:
                    return new Junk(
                        Guid.NewGuid(),
                        "Vile of Mystical Fluid",
                        Properties.Resources.Vile_of_Mystical_Fluid,
                        false,
                        1.3f,
                        InventorySlotId.UNEQUIPPABLE,
                        8);
                default:
                    throw new Exception();
            }
        }

        public Item GenerateMerchantItems()
        {
            switch (_rand.Next(1, 4))
            {
                case 1:
                    return SpawnHelmet();
                case 2:
                    return SpawnVest();
                case 3:
                    return SpawnWeapon();
                case 4:
                    return SpawnPotion();
                default:
                    throw new Exception();
            }
        }

    }
}
