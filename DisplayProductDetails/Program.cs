using System;

namespace Product;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the product id: ");
        int ProductId = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the product name: ");
        string ProductName = Console.ReadLine();
        Console.WriteLine("Enter the product cost");
        float ProductCost = float.Parse(Console.ReadLine());

        Product pid = new Product();
        Product pname= new Product();
        Product pcost= new Product();
        pid.ProductId = ProductId;
        pname.ProductName = ProductName;
        pcost.ProductCost = ProductCost;

        Console.WriteLine(new Program().DisplayProjects(pid,pname,pcost));
        
    }
    public string DisplayProjects(Product ob1,Product ob2, Product ob3)
    {
        int productID = ob1.ProductId;
        String name = ob2.ProductName;
        float cost = ob3.ProductCost;
        String s = $"Product id is: {productID} \n{name} is on sale for {cost}$";
        return s;
    }
}