﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBHModels.Dtos
{
    public class CartItemDto
    {
        public int Id { get; set; }
        public string CartId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImageUrl { get; set; }
        public decimal Price {  get; set; }
        public decimal TotalPrice { get; set; }
        public int Qty { get; set; }

    }
}
