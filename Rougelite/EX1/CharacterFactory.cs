using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    public class CharacterFactory
    {
        private Random _rand = new Random();
        private ItemFactory _itemFactory = new ItemFactory();

        public CharacterFactory()
        {

        }
        string[] _heroNames = new string[]
        {
            "Snake Plissken",
            "Xander Cage",
            "Jericho Cane",
            "John Rambo",
            "Tyler Durden",
            "Chuck Norris"
        };

        string[] _stage1EnemyNames = new string[]
        {
            "Splinter",
            "Radagast",
            "Fenthris",
            "Leviathon",
            "Cerberus",
            "Hydra"
        };
        string[] _stage2EnemyNames = new string[]
        {
            "Triclops",
            "Adamance",
            "Whisper",
            "Ion",
            "Chaos",
            "Knightmare"
        };
        string[] _stage3EnemyNames = new string[]
        {
            "Inanos",
            "Gale",
            "Salvus",
            "Narcos",
            "Sanguin",
            "Umbrus"
        };
        string[] _stage4EnemyNames = new string[]
        {
            "Jacan",
            "Datryon",
            "Cronix",
            "Kehua",
            "Vraucorn",
            "Sopad"
        };
        string[] _stage5EnemyNames = new string[]
        {
            "Ybaldir - God of Earth",
            "Nilios - God of Dusk",
            "Obum - God of Infamy",
            "Nosyn - Goddess of Shadows",
            "Uqotl - Goddess of Torture",
            "Irelia - Goddess of Judgement",
            "Zatar - God of Insanity",
            "Seleyar - God of Destruction",
            "Ehbris - God of Death",
            "Kuvta - Goddess of Penance",
            "Kuclena - Goddess of Dawn",
            "Arta - Goddess of Revenge"
        };

        public Character SpawnPlayer()
        {
            Character hero = new Character(
                _heroNames[_rand.Next(0, _heroNames.Length)],
                _rand.Next(51, 101),
                _rand.Next(1, 51),
                _rand.Next(1, 26)
                );

            hero.Helmet = _itemFactory.SpawnHelmet();
            hero.Vest = _itemFactory.SpawnVest();
            hero.Blade = _itemFactory.SpawnWeapon();
            hero.Potion = _itemFactory.SpawnPotion();

            hero.Bag.Add(_itemFactory.SpawnPotion());
            hero.Bag.Add(_itemFactory.SpawnPotion());

            return hero;
        }
        public Character SpawnEnemy(int level)
        {
            Character enemy;
            if (level >= 0 && level <= 4)
            {
                enemy = SpawnStage1Enemy();
            }
            else if(level == 5)
            {
                enemy = SpawnStage1Boss();
            }
            else if(level >= 6 && level <= 9)
            {
                enemy = SpawnStage2Enemy();
            }
            else if(level == 10)
            {
                enemy = SpawnStage2Boss();
            }
            else if(level >= 11 && level <= 14)
            {
                enemy = SpawnStage3Enemy();
            }
            else if(level == 15)
            {
                enemy = SpawnStage3Boss();
            }
            else if(level >= 16 && level <= 19)
            {
                enemy = SpawnStage4Enemy();
            }
            else if(level == 20)
            {
                enemy = SpawnStage4Boss();
            }
            else if(level >= 21 && level <= 49)
            {
                enemy = SpawnStage5Enemy();
            }
            else
            {
                enemy = SpawnDOOM();
            }
            
            enemy.Bag.Add(_itemFactory.SpawnJunk());
            enemy.Bag.Add(_itemFactory.SpawnJunk());
            return enemy;
        }
        public Character SpawnStage1Enemy()
        {
            Character enemy = new Character(
               _stage1EnemyNames[_rand.Next(0, _stage1EnemyNames.Length)],
               _rand.Next(1, 51),
               _rand.Next(1, 51),
               _rand.Next(1, 26)
               );

            enemy.Helmet = _itemFactory.SpawnStage1EnemyHelmet();
            enemy.Vest = _itemFactory.SpawnStage1EnemyVest();
            enemy.Blade = _itemFactory.SpawnStage1EnemyWeapon();

            return enemy;
        }
        public Character SpawnStage2Enemy()
        {
            Character enemy = new Character(
               _stage2EnemyNames[_rand.Next(0, _stage2EnemyNames.Length)],
               _rand.Next(11, 61),
               _rand.Next(1, 51),
               _rand.Next(1, 26)
               );

            enemy.Helmet = _itemFactory.SpawnStage2EnemyHelmet();
            enemy.Vest = _itemFactory.SpawnStage2EnemyVest();
            enemy.Blade = _itemFactory.SpawnStage2EnemyWeapon();

            return enemy;
        }
        public Character SpawnStage3Enemy()
        {
            Character enemy = new Character(
               _stage3EnemyNames[_rand.Next(0, _stage3EnemyNames.Length)],
               _rand.Next(21, 71),
               _rand.Next(1, 51),
               _rand.Next(1, 26)
               );

            enemy.Helmet = _itemFactory.SpawnStage3EnemyHelmet();
            enemy.Vest = _itemFactory.SpawnStage3EnemyVest();
            enemy.Blade = _itemFactory.SpawnStage3EnemyWeapon();

            return enemy;
        }
        public Character SpawnStage4Enemy()
        {
            Character enemy = new Character(
               _stage4EnemyNames[_rand.Next(0, _stage4EnemyNames.Length)],
               _rand.Next(31, 81),
               _rand.Next(1, 51),
               _rand.Next(1, 26)
               );

            enemy.Helmet = _itemFactory.SpawnStage4EnemyHelmet();
            enemy.Vest = _itemFactory.SpawnStage4EnemyVest();
            enemy.Blade = _itemFactory.SpawnStage4EnemyWeapon();

            return enemy;
        }
        public Character SpawnStage5Enemy()
        {
            Character enemy = new Character(
               _stage5EnemyNames[_rand.Next(0, _stage5EnemyNames.Length)],
               _rand.Next(41, 91),
               _rand.Next(1, 51),
               _rand.Next(1, 26)
               );

            enemy.Helmet = _itemFactory.SpawnStage5EnemyHelmet();
            enemy.Vest = _itemFactory.SpawnStage5EnemyVest();
            enemy.Blade = _itemFactory.SpawnStage5EnemyWeapon();

            return enemy;
        }
        public Character SpawnStage1Boss()
        {
            Character enemy = new Character(
               "The BloodMoon Stalkers",
               _rand.Next(11, 61),
               _rand.Next(1, 51),
               _rand.Next(1, 26)
               );

            enemy.Helmet = null;
            enemy.Vest = new Armor(
                Guid.NewGuid(),
                "Wolven Armor",
                Properties.Resources.Wolven_Armor,
                false,
                5,
                InventorySlotId.VEST,
                85,
                45);
            enemy.Blade = new Weapon(
                Guid.NewGuid(),
                "Wolf Claws",
                Properties.Resources.Wolf_Claws,
                true,
                4,
                InventorySlotId.WEAPON,
                200,
                45);

            return enemy;
        }
        public Character SpawnStage2Boss()
        {
            Character enemy = new Character(
               "Runnemon - The Deceiver",
               _rand.Next(21, 71),
               _rand.Next(1, 51),
               _rand.Next(1, 26)
               );

            enemy.Helmet = new Armor(
                Guid.NewGuid(),
                "Helmet of the Deceiver",
                Properties.Resources.Helmet_of_the_Deceiver,
                false,
                5,
                InventorySlotId.HELMET,
                30,
                30);
            enemy.Vest = new Armor(
                Guid.NewGuid(),
                "Chest Plate of the Deciever",
                Properties.Resources.Chest_Plate_of_the_Deciever,
                false,
                10,
                InventorySlotId.VEST,
                30,
                45);
            enemy.Blade = new Weapon(
                Guid.NewGuid(),
                "Dagger of the Deceiver",
                Properties.Resources.Dagger_of_the_Deceiver,
                false,
                8,
                InventorySlotId.WEAPON,
                56,
                45);

            return enemy;
        }
        public Character SpawnStage3Boss()
        {
            Character enemy = new Character(
               "Cyrene Killorean",
               _rand.Next(31, 81),
               _rand.Next(1, 51),
               _rand.Next(1, 26)
               );

            enemy.Helmet = new Armor(
                Guid.NewGuid(),
                "Cyrene's Brow",
                Properties.Resources.Cyrene_s_Brow,
                false,
                4,
                InventorySlotId.HELMET,
                45,
                45);
            enemy.Vest = new Armor(
                Guid.NewGuid(),
                "Dark Magic Armor",
                Properties.Resources.Dark_Magic_Armor,
                false,
                4,
                InventorySlotId.VEST,
                23,
                45);
            enemy.Blade = new Weapon(
                Guid.NewGuid(),
                "Staff of Endless Fire",
                Properties.Resources.Staff_of_Endless_Fire,
                false,
                8,
                InventorySlotId.WEAPON,
                100,
                45);

            return enemy;
        }
        public Character SpawnStage4Boss()
        {
            Character enemy = new Character(
               "Vecna",
               _rand.Next(41, 91),
               _rand.Next(1, 51),
               _rand.Next(1, 26)
               );

            enemy.Helmet = new Armor(
                Guid.NewGuid(),
                "Helm of the All-Seeing Eye",
                Properties.Resources.Helm_of_the_All_Seeing_Eye,
                false,
                4,
                InventorySlotId.HELMET,
                200,
                45);
            enemy.Vest = new Armor(
                Guid.NewGuid(),
                "Necromancer's Robes",
                Properties.Resources.Necromancers_Robes,
                false,
                4,
                InventorySlotId.VEST,
                200,
                45);
            enemy.Blade = new Weapon(
                Guid.NewGuid(),
                "The Hand of Vecna",
                Properties.Resources.The_Hand_of_Vecna,
                false,
                2,
                InventorySlotId.WEAPON,
                200,
                45);

            return enemy;
        }
        public Character SpawnDOOM()
        {
            Character enemy = new Character(
               "DOOM",
               _rand.Next(2000, 5001),
               _rand.Next(3000, 6001),
               _rand.Next(2000, 3001)
               );

            enemy.Helmet = null;
            enemy.Vest = null;
            enemy.Blade = null;

            return enemy;
        }
    }
}
