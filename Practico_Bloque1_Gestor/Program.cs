using Practico_Bloque1_Gestor.Models;
using Practico_Bloque1_Gestor.Repositories;

IProductRepository repo = new ProductRepository();

//impresión de la lista completa.
Console.WriteLine("Productos en el repositorio:");

foreach (var product in repo.GetAll())
{
    Console.WriteLine($"{product.Name} ({product.Category}): ${product.Price:F2}");
}

Console.WriteLine("------------------------------------");
//búsqueda de un producto por ID.

Console.WriteLine("Ingrese el ID del producto a buscar:");
if (int.TryParse(Console.ReadLine(), out int id))
{
    var product = repo.GetById(id);
    if (product != null)
    {
        Console.WriteLine($"{product.Name} ({product.Category}): ${product.Price:F2}");
    }
    else
    {
        Console.WriteLine("Producto no encontrado.");
    }
}
else
{
    Console.WriteLine("ID inválido.");
}

Console.WriteLine("------------------------------------");

//filtrado de productos por categoría.

Console.WriteLine("Ingrese la categoría de los productos a buscar:");

string category = Console.ReadLine();

var filteredProducts = repo.GetByCategory(category);

Console.WriteLine($"Productos en la categoría '{category}':");

foreach (var product in filteredProducts)
{
    Console.WriteLine($"{product.Name} ({product.Category}): ${product.Price:F2}");
}

Console.WriteLine("------------------------------------");

// incorporación de un nuevo producto
Console.WriteLine("Ingrese el nombre del nuevo producto:");
string newName = Console.ReadLine();
Console.WriteLine("Ingrese el precio del nuevo producto:");
if (decimal.TryParse(Console.ReadLine(), out decimal newPrice))
{
    Console.WriteLine("Ingrese la categoría del nuevo producto:");
    string newCategory = Console.ReadLine();
    Console.WriteLine("Ingrese el estado del nuevo producto (true/false):");
    if (bool.TryParse(Console.ReadLine(), out bool newActive))
    {
        int newId = repo.GetAll().Count + 1; // Genera un nuevo ID basado en la cantidad de productos existentes.
        Product newProduct = new Product
        {
            Id = newId,
            Name = newName,
            Price = newPrice,
            Category = newCategory,
            Active = newActive
        };
        repo.Add(newProduct);
        Console.WriteLine("Producto agregado correctamente.");
    }
    else
    {
        Console.WriteLine("Estado inválido. El producto no se agregó.");
    }
}
else
{
    Console.WriteLine("Precio inválido. El producto no se agregó.");
}

