using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    [Serializable]
    public class EquippedItems : IEnumerable<Item>
    {
        private Dictionary<InventorySlotId, Item> _items;

        public EquippedItems()
        {
            _items = new Dictionary<InventorySlotId, Item>();
        }
        public void Equip(InventorySlotId slot, Item item)
        {
            _items[slot] = item;
        }

        public IEnumerator<Item> GetEnumerator()
        {
            return _items.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public Item Unequip(InventorySlotId slot)
        {
            Item removedItem = _items[slot];
            _items[slot] = null;
            return removedItem;
        }
        public Item this[InventorySlotId slot]
        {
            get { return _items[slot]; }
            set { _items[slot] = value; }
        }
    }
}
