﻿using WebBHModels.Dtos;
using WebsiteBanHang.Entities;

namespace API.Extensions
{
    public static class DtoConversions
    {
        // LINQ 
        public static IEnumerable<ProductDto> ConvertToDto(this IEnumerable<Product> products, IEnumerable<ProductCategory> productCategories)
        {
            return (from product in products
                    join productCategory in productCategories
                    on product.CategoryId equals productCategory.Id
                    select new ProductDto
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Description = product.Description,
                        ImageUrl = product.ImageUrl,
                        Price = product.Price,
                        Qty = product.Qty,
                        CategoryId = product.CategoryId,
                        CategoryName = productCategory.Name
                        
                    }).ToList();
        }

        public static ProductDto ConvertToDto(this Product product, ProductCategory productCategory)
        {
            //return (from product in products
            //        join productCategory in productCategories
            //        on product.CategoryId equals productCategory.Id
            //        select new ProductDto
            //        {
            //            Id = product.Id,
            //            Name = product.Name,
            //            Description = product.Description,
            //            ImageUrl = product.ImageUrl,
            //            Price = product.Price,
            //            Qty = product.Qty,
            //            CategoryId = product.CategoryId,
            //            CategoryName = productCategory.Name

            //        }).ToList();
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                ImageUrl = product.ImageUrl,
                Price = product.Price,
                Qty = product.Qty,
                CategoryId = product.CategoryId,
                CategoryName = productCategory.Name
            };
        }
    }


}
