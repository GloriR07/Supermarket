using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public class VariablePriceProduct : Product
    {
        public float Measurement { get; set; }

        public int Quantity { get; set; }
        public override string ValueToPay()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
