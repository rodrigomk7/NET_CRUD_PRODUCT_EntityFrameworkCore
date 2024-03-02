using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcProduc.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Description { get; set; }

        public decimal Price { get; set; }
        
        public bool State { get; set; }
        
        public DateTime loadDate { get; set; }
    }
}