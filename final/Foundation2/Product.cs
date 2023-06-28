public class Product{
    private string _productId;
    private string _name;
    private double _price;
    private int _quantity;

    public Product(string productId, string name, double price, int quantity)
    {
        _productId = productId;
        _name = name;
        _price = price;
        _quantity = quantity;
    }

    public double GetProductTotal(){
        return _price * _quantity;
    }

    public string DisplayProduct(){
        return $"{_name} ({_productId}) Qty: {_quantity}";
    }



}