namespace Supermarket
{
    public abstract class Product
    {
        public string Description { get; set; }

        public int Id { get; set; }

        public Decimal Price { get; set; }

        public float Tax { get; set; }

        public override string ToString()
        {
            return $"{Description} {Id}  Price: {Price}, Tax:{(Price * (decimal)Tax) + Price}";
        }
        public abstract string ValueToPay();



    }
}

