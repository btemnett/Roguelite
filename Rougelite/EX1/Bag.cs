using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    [Serializable]
    public class Bag : IEnumerable<Item>
    {
        private List<Item> _items;
        private float _totalWeight;
        private float _maxWeight;

        public Bag(float maxWeight)
        {
            _items = new List<Item>();
            _totalWeight = 0;
            _maxWeight = maxWeight;
        }
        public void Add(Item item)
        {
            float itemWeight = item.Weight;
            if(itemWeight + _totalWeight > _maxWeight)
            {
                throw new BagFullException(
                    "Your bag is Full. Item was not added." + "\r\n" +
                    "Try selling some items.");
            }
            else
            {
                _items.Add(item);
                _totalWeight += itemWeight;
            }
            
        }
        public Item RemoveAt(int index)
        {
            Item removed = _items[index];
            _items.RemoveAt(index);
            _totalWeight -= removed.Weight;
            return removed;
        }
        public Item RemoveById(Guid id)
        {
            int removedIndex = _items.FindIndex(x => x.Id == id);
            if(removedIndex < 0)
            {
                return null;
            }
            else
            {
                return RemoveAt(removedIndex);
            }
        }
        public IEnumerator<Item> GetEnumerator()
        {
            return _items.GetEnumerator();
            //for(int i = 0; i < _items.Count; ++i)
            //{
            //    yield return _items[i];
            //}
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Count
        {
            get { return _items.Count; }
        }
        public float TotalWeight
        {
            get { return _totalWeight; }
        }
        public float MaxWeight
        {
            get { return _maxWeight; }
        }
        public Item this[int index]
        {
            get { return _items[index]; }
        }
        public void SortByName()
        {
            _items.Sort((x, y) => x.Name.CompareTo(y.Name));
        }
        public void SortByWeight()
        {
            _items.Sort((x, y) => x.Weight.CompareTo(y.Weight));
        }
        public void SortByGoldValue()
        {
            _items.Sort((x, y) => x.GoldValue.CompareTo(y.GoldValue));
        }
        public void SortByAttack()
        {
            _items.Sort((x, y) => 
            {
                Weapon a = x as Weapon;
                Weapon b = y as Weapon;
                int c = (a != null ? a.ATK : 0);
                int d = (b != null ? b.ATK : 0);
                return -c.CompareTo(d); // was b
            });
        }
        public void SortByDefense()
        {
            _items.Sort((x, y) => 
            {
                Armor a = x as Armor;
                Armor b = y as Armor;
                int c = (a != null ? a.Def : 0);
                int d = (b != null ? b.Def : 0);
                return -c.CompareTo(d); // was b
            });
        }
    }
}
