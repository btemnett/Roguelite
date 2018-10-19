using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    [Serializable]
    public class Character
    {
        protected string _name;
        protected int _hp;
        protected int _atk;
        protected int _def;
        protected bool _dead;
        protected Bag _bag;
        protected EquippedItems _equipped;
        protected bool _isDOOMed;


        public Character(
            string name,
            int hp,
            int atk,
            int def)
        {
            _name = name;
            _hp = hp;
            _atk = atk;
            _def = def;
            _dead = false;
            _bag = new Bag(40.0f);
            _equipped = new EquippedItems();
            _isDOOMed = false;
        }
        
        public string Name
        {
            get { return _name; }
        }

        public int Hp
        {
            get { return _hp; }
        }

        public int TotalAtk
        {
            get
            {
                int x = _atk;
                if (Blade != null)
                {
                    x += Blade.ATK;
                }
                return x;
            }
        }

        public int TotalDef
        {
            get
            {
                int x = _def;
                if(Helmet != null)
                {
                    x += Helmet.Def;
                }
                if(Vest != null)
                {
                    x += Vest.Def;
                }
                return x;
            }
        }

        public bool IsDead
        {
            get { return _dead; }
        }

        public Bag Bag
        {
            get { return _bag; }
        }

        public EquippedItems Equipped
        {
            get { return _equipped; }
        }

        public Armor Helmet
        {
            get { return _equipped[InventorySlotId.HELMET] as Armor; }
            set { _equipped[InventorySlotId.HELMET] = value; }
        }

        public Armor Vest
        {
            get { return _equipped[InventorySlotId.VEST] as Armor; }
            set { _equipped[InventorySlotId.VEST] = value; }
        }

        public Weapon Blade
        {
            get { return _equipped[InventorySlotId.WEAPON] as Weapon; }
            set { _equipped[InventorySlotId.WEAPON] = value; }
        }

        public Potion Potion
        {
            get { return _equipped[InventorySlotId.POTION] as Potion; }
            set { _equipped[InventorySlotId.POTION] = value; }
        }
        public bool IsDOOMed
        {
            get { return _isDOOMed; }
        }

        public void ApplyDamage(int damage)
        {
            if(damage >= -1)
            {
                damage = -1;
            }
            
            Debug.Assert(damage < 0);
            _hp += damage;
            if (_hp <= 0)
            {
                _dead = true;
                _hp = 0;
            }
        }

        public void Heal(int healing)
        {
            Debug.Assert(healing >= 0);

            _hp += healing;
        }
        public void DOOM()
        {
            _hp = 1;
            _atk = 1;
            _def = 1;
            Helmet = null;
            Vest = null;
            Blade = null;
            _isDOOMed = true;
        }
    }
}
