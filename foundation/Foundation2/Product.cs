using System;
public class Product
{
    private string _productName;
    private int _id;
    private double _price;
    private double _quantity;

    public Product(string product, int id, double price, int quantity)
    {
        _productName = product;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public double GetProductPrice()
    {
        return _price * _quantity;
    }

    public string ProductLabel()
    {
        return $"{_productName} ID: {_id}. \n";
    }

}