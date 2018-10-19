using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EX1
{
    [Serializable]
    public class Junk : Item
    {
        public Junk(
            Guid id,
            string name,
            Image image,
            bool natural,
            float weight,
            InventorySlotId slot,
            int goldValue)
            : base(
                id,
                name,
                image,
                natural,
                weight,
                slot,
                goldValue)
        {

        }
        public override string ToString()
        {
            return _name;
        }
    }
}
