using API.Services.Contracts;
using Microsoft.AspNetCore.Components;
using WebBHModels.Dtos;

namespace WebsiteBanHang.Pages
{
    public class ProductBase : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }
        public IEnumerable<ProductDto> Products { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Products = await ProductService.GetItems();
        }

        protected IOrderedEnumerable<IGrouping<int, ProductDto>> GetGroupedProductsByCategory()
        {
            return from product in Products
                   group product by product.CategoryId into productByCategory
                   orderby productByCategory.Key
                   select productByCategory;
        }
    }
}
