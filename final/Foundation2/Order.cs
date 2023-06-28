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


    public double CalculateOrderTotal()
    {
        double orderTotal = _products.Sum(x=>x.GetProductTotal());
        if(_customer.IsUSA()){orderTotal +=5;}
        else{orderTotal +=35;}
        return orderTotal;
    }

    public string PackingLabel()
    {
        string packingLabel = $"Packing Lable:\n";
        foreach (var item in _products)
        {
            packingLabel += $" {item.DisplayProduct()}\n";
        }

        return packingLabel;
    }
    public string ShippingLabel()
    {
        string shippingLabel = $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress()}";
        return shippingLabel;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }


}