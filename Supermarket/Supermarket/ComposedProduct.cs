namespace Supermarket
{
    public class ComposedProduct : Product
    {
        public decimal Discount { get; set; }

        public List<Product> Products { get; set; }

        public override decimal  ValueToPay()
        {
            decimal TotPrice = 0;

            foreach (Product superM in Products) {
                TotPrice = TotPrice + superM.ValueToPay();
            }
            return TotPrice - (TotPrice * (decimal)Discount);
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
