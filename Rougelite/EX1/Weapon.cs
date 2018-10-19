using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EX1
{
    [Serializable]
    public class Weapon : Item
    {
        protected int _atk;

        public Weapon(Guid id,
            string name,
            Image image,
            bool natural,
            float weight,
            InventorySlotId slot,
            int goldValue,
            int atk)
            : base(
                id,
                name,
                image,
                natural,
                weight,
                slot,
                goldValue)
        {
            _atk = atk;
        }
        public int ATK
        {
            get { return _atk; }
        }
        public override string ToString()
        {
            return $"{_name} (+{_atk})";
        }
    }
}
