using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBHModels.Dtos
{
    // show thông tin chi tiết của sp
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }  
        public int Qty {  get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
