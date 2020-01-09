using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace gimc.Models
{
    public class Product : Entity
    {
        public string VendorUID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<ProductFlag> DietaryFlags { get; set; }

    }


    public class DietaryFlag : Entity
    {
        public string Title { get; set; }
        
        public ICollection<ProductFlag> UsedInProducts { get; set; }
    }


    public class ProductFlag : Entity
    {
        public int FlagId { get; set; }
        public int ProductId { get; set; }
        public DietaryFlag Flag { get; set; }
        public Product Product { get; set; }

    }

}
