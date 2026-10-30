using Practico_Bloque1_Gestor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practico_Bloque1_Gestor.Repositories
{
    internal class ProductRepository : IProductRepository
    {
        // Utilizar una List<Producto> privada para almacenar los registros de forma temporal.
        private readonly List<Product> _products;
        

        public ProductRepository()
        {
            _products = new List<Product>()
            {
            new Product { Id = 1, Name = "Producto 1", Price = 10.99m, Category = "Limpieza", Active = true },
            new Product { Id = 2, Name = "Producto 2", Price = 19.99m, Category = "Liquidos", Active = true },
            new Product { Id = 3, Name = "Producto 3", Price = 5.99m, Category = "Jabones", Active = false },
            new Product { Id = 4, Name = "Producto 4", Price = 15.49m, Category = "Lacteos", Active = true }
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }
        
        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetByCategory(string category)
        {
            return _products.Where(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public Product GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }
}
