using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EX1
{
    [Serializable]
    public class Armor : Item
    {
        protected int _def;

        public Armor(Guid id,
            string name,
            Image image,
            bool natural,
            float weight,
            InventorySlotId slot,
            int goldValue,
            int def)
            : base(
                id,
                name,
                image,
                natural,
                weight,
                slot,
                goldValue)
        {
            _def = def;
        }
        public int Def
        {
            get { return _def; }
        }
        public override string ToString()
        {
            return $"{_name} (+{_def})";
        }
    }
}
