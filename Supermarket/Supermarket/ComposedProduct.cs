namespace Supermarket
{
    public class ComposedProduct : Product
    {
        public decimal Discount { get; set; }

        public List<Product> Products { get; set; }

        public override decimal  ValueToPay()
        {
            decimal TotPrice = 0;

            foreach (Product  in Products) {
            }
            return TotPrice - (TotPrice * (decimal)Discount);
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
