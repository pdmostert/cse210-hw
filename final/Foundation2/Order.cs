public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new();

    }
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }


    public double CalcualteOrderTotal()
    {
        return 0;
    }

    public string PackingLabel()
    {
        return "";
    }
    public string ShippingLabel()
    {
        return "";
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }


}