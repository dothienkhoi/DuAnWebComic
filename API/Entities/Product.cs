﻿namespace WebsiteBanHang.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }

        // danh mục sản phẩm
        public int CategoryId { get; set; }
        //public ProductCategory Category { get; set; }
    }
}
