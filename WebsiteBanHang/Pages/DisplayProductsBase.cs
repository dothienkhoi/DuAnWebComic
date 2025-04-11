using API.Services.Contracts;
using Microsoft.AspNetCore.Components;
using System.ComponentModel;
using WebBHModels.Dtos;

namespace WebsiteBanHang.Pages
{
    public class DisplayProductsBase : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; }
        //protected override async Task OnInitializedAsync()
        //{
        //    Products = await ProductService.GetItems();
        //}
    }
}
