﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace boutiq.Models
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateOfSale { get; set; }
        public string ClothType { get; set; }
        public int SalePrice { get; set; }
        public string Description { get; set; }
        public int ItemSold { get; set; }
    }
}
