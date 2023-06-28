using System;

class Program
{
    static void Main(string[] args)
    {
        // create 2 customers
        List<Order> orders = new();

        Customer customer1 = new Customer("Bob Larsen", new Address("10 Garcia Street", "East London", "Eastern Cape", "RSA"));
        Customer customer2 = new Customer("Joe Smith", new Address("15 Edison Street", "Salt Lake City", "Utah", "USA"));

        //create 2 orders with 2-3 products
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("FRT001", "Freshness Guaranteed Honeycrisp Apples, 3 lb Bag", 9.32, 3));
        order1.AddProduct(new Product("VEG003","Fresh Whole Carrots, 1 lb Bag",0.98,2));
        order1.AddProduct(new Product("H2O001","Smartwater vapor distilled premium water, 1 liter, 6 count bottles",10.68,1));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("FRT002","Fresh Navel Oranges, Each",0.88,10));       
        order2.AddProduct(new Product("VEG002","Fresh Roma Tomato, Each",0.38,5));
        order2.AddProduct(new Product("STR001","Zatarain's Jambalaya Rice - Family Size, 12 oz",2.74,1));


        orders.Add(order1);
        orders.Add(order2);

        foreach (var item in orders)
        {
        System.Console.WriteLine($"Order Total $ {String.Format("{0:0.00}", item.CalculateOrderTotal())}");
        System.Console.WriteLine();
        System.Console.WriteLine(item.PackingLabel());
        System.Console.WriteLine();
        System.Console.WriteLine(item.ShippingLabel());
        System.Console.WriteLine();
        }
      


        //get packign label, 
        // get shipping label

        //display total price of order


    }
}