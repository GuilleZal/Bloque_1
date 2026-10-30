using Practico_Bloque1_Gestor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practico_Bloque1_Gestor.Repositories
{
    internal interface IProductRepository
    {
        void Add(Product product);
        List<Product> GetAll();
        Product GetById(int id);
        List<Product> GetByCategory(string category);
    }
}
