using System;
using System.Collections.Generic;
using System.Text;

namespace Practico_Bloque1_Gestor.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public bool Active { get; set; }
    }
}
