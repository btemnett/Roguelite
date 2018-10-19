using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EX1
{
    [Serializable]
    public abstract class Item
    {
        protected Guid _id;
        protected string _name;
        protected Image _image;
        protected bool _natural;
        protected float _weight;
        protected InventorySlotId _slot;
        protected int _goldValue;

        public Item(
            Guid id,
            string name, 
            Image image,
            bool natural,
            float weight,
            InventorySlotId slot,
            int goldValue)
        {
            _id = id;
            _name = name;
            _image = image;
            _natural = natural;
            _weight = weight;
            _slot = slot;
            _goldValue = goldValue;
        }
        public Guid Id
        {
            get { return _id; }
        }
        public string Name
        {
            get { return _name; }
        }
        public Image Image
        {
            get { return _image; }
        }
        public bool IsNatural
        {
            get { return _natural; }
        }
        public float Weight
        {
            get { return _weight; }
        }
        public InventorySlotId Slot
        {
            get { return _slot; }
        }
        public int GoldValue
        {
            get { return _goldValue; }
        }
        public override string ToString()
        {
            return _name;
        }
        public override bool Equals(object obj)
        {
            Item other = obj as Item;
            if (other == null)
            {
                return false;
            }
            else
            {
                return other.Id == this.Id;
            }
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
