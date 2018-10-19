using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    public class BagFullException : Exception
    {
        public BagFullException(string message) : base(message)
        {

        }
    }
}
