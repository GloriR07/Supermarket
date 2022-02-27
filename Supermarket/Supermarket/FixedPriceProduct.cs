namespace Supermarket
{
    public class FixedPriceProduct : Product
    {
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

