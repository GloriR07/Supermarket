namespace Supermarket
{
    public class VariablePriceProduct : Product
    {
        public float Measurement { get; set; }

        public int Quantity { get; set; }
        public override decimal ValueToPay()
        {
            return Price * Quantity + (Price * Quantity * (decimal)Tax);
        }

        public override string ToString()
        {
            return $"{ base.ToString()}\n\t" +
                $"Measurement...:{$"{Measurement}",5}\n\tQuantity......:{$"{Quantity:N2}",15}\n\t" +
                $"Price.........:{$"{Price:C2}",15}\n\tTax...........:{ $"{Tax:P2}",15}\n\t" +
                $"Value.........:{ $"{ValueToPay():C2}",15}";
        }
    }
}

