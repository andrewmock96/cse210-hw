public class Product
{
    private string _name;
    private string _productId;
    private int _price;
    private int _quantity;

    public Product(string name, string productId, int price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

     public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public decimal GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
    
    //Method to calculate total cost
    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }
}