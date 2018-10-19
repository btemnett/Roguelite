using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EX1
{
    [Serializable]
    public class Potion : Item
    {
        protected int _healValue;

        public Potion(
            Guid id,
            string name,
            Image image,
            bool natural,
            float weight,
            InventorySlotId slot,
            int goldValue,
            int healValue)
            : base(
                id,
                name,
                image,
                natural,
                weight,
                slot,
                goldValue)
        {
            _healValue = healValue;
        }
        public int HealValue
        {
            get { return _healValue; }
        }
        public override string ToString()
        {
            return $"{_name} (+{_healValue})";
        }
    }
}
