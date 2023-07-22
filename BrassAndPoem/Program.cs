//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
using System;
using System.Collections.Generic;
using System.Linq;


List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Flugelhorn",
        Price = 199.99M,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "The Road Not Taken",
        Price = 10.28M,
        ProductTypeId = 2
    },
    new Product()
    {
        Name = "Trumpet",
        Price = 849.99M,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Trombone",
        Price = 349.99M,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "O Captain! My Captain!",
        Price = 12.26M,
        ProductTypeId = 2
    },
};
//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 
List<ProductType> productTypes = new List<ProductType>()
{
    new ProductType()
    {
        Title = "Brass Instrument",
        Id = 1
    },
    new ProductType()
    {
        Title = "Poem",
        Id = 2
    }
};
//put your greeting here
string greeting = @"Welcome to Brass and Poems!
Your one-stop shop for brass instruments and classic poems!";
Console.WriteLine(greeting);
//implement your loop here
DisplayMenu();

void DisplayMenu()
{
    string choice = null;
    while (choice != "0")
    {
        Console.WriteLine(@"Choose an option:
   1. Display all products
   2. Delete a product
   3. Add a new product
   4. Update product properties
   0. Exit");
        choice = Console.ReadLine();
        if (choice == "1")
        {
            DisplayAllProducts(products, productTypes);
        }
        else if (choice == "2")
        {
            DeleteProduct(products, productTypes);

        }
        else if (choice == "3")
        {
            AddProduct(products, productTypes);
        }
        else if (choice == "4")
        {
            UpdateProduct(products, productTypes);
        }
        else if (choice == "0")
        {
            Console.WriteLine("GoodBye!");
        }
        else if (choice != "1" || choice != "2" || choice != "3" || choice != "4" || choice != "0")
        {
            Console.WriteLine("Select the number of an existing menu option!");
        }
    }
}


void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Products:");

    for (int i = 0; i < products.Count; i++)
    {
        var query = from x in productTypes
                    where products[i].ProductTypeId == x.Id
                    select new { x.Title };
        var productType = query.First();
        Console.WriteLine($"{i + 1} . {products[i].Name} - {productType.Title} - ${products[i].Price}");
    }
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    DisplayAllProducts(products, productTypes);
    Console.WriteLine("Select the product index you wish to remove.");
    Console.WriteLine("Select 0 to exit to menu.");

    int response = int.Parse(Console.ReadLine().Trim());
    if (response >= 1 && response <= products.Count)
    {
        products.RemoveAt(response - 1);
        Console.WriteLine("Product Removed.");
    }
    else 
    { 
        Console.WriteLine("No product selected. Returning to main menu.");
    }
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine(@"Choose product type:
    1. Brass
    2. Poem");
    int newProductId = int.Parse(Console.ReadLine().Trim());

    Console.WriteLine("Enter Product Name.");
    string newProductName = Console.ReadLine().Trim();

    Console.WriteLine("Enter Price.");
    decimal newProductPrice = decimal.Parse(Console.ReadLine().Trim());

    Product newProduct = new Product
    {
        Name = newProductName,
        Price = newProductPrice,
        ProductTypeId = newProductId
    };
    products.Add(newProduct);
}
void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Current Product selection:");
    DisplayAllProducts(products, productTypes);

    Console.Write("Enter the index of the product to update:");
    int indexToUpdate = int.Parse(Console.ReadLine().Trim());

    if (indexToUpdate >= 1 && indexToUpdate <= products.Count)
    {
        Console.Write("Enter the updated name of the product: ");
        string updatedProductName = Console.ReadLine().Trim();

        Console.Write("Enter the updated price of the product: ");
        decimal updatedProductPrice = decimal.Parse(Console.ReadLine().Trim());

        Console.WriteLine(@"Choose updated product type:
        1. Brass
        2. Poem");
        int updatedProductId = int.Parse(Console.ReadLine().Trim());

        Product productToUpdate = products[indexToUpdate - 1];
        productToUpdate.Name = updatedProductName;
        productToUpdate.Price = updatedProductPrice;
        productToUpdate.ProductTypeId = updatedProductId;

        Console.WriteLine("Product updated successfully.");

        Console.WriteLine("Updated list of products:");
        DisplayAllProducts(products, productTypes);
    }
    else
    {
        Console.WriteLine("Invalid index. No product was updated.");
    }
}

// don't move or change this!
public partial class Program { }