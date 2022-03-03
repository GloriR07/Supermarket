namespace Supermarket
{
    public class Invoice : IPay

    {
        private string Products;
    }

    public class Invoice
    {

    }
    public class AddProduct
    {

    }   

    public abstract decimal ValueToPay();


    public override string ToString()
    {
        return base.ToString();
    }


}
