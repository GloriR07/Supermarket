using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public class ComposedProduct : Product
    {
        public Decimal Discount { get; set; }

        public string Products { get; set; }
        public override string ValueToPay()
        {
            throw new NotImplementedException();
        }
    }
}
