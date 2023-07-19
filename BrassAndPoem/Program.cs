
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
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
        Title = "Brass",
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
Your one-stop shop for Brass Instruments and classic Poems!";
Console.WriteLine(greeting);
//implement your loop here

void DisplayMenu()
{
    throw new NotImplementedException();
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }