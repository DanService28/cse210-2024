using System;
using System.Numerics;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(List<Product> product, Customer customer)
    {
        _products = product;
        _customer = customer;
    }

    public double GetTotalPrice()
    {
        double TotalPrice = 0;

        foreach(var product in _products)
        {
            TotalPrice += product.GetProductPrice();
        }

        double shippingCost = 0;
        if (_customer.UserIsInUsa())
        {
            shippingCost += 35;
        }
        else
        {
            shippingCost += 5;
        }

        return TotalPrice + shippingCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Products List:\n";
        
        foreach(var product in _products)
        {
            packingLabel += product.ProductLabel();
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\nCustomer: {_customer.Name}\nAddress: {_customer.Address.DisplayAddress()}";
    }
}