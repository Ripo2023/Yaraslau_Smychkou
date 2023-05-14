using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MobileStore.Gateway.Common.RequestModels
{
    public class GetCategoryProductsRequestModel : GetByPageRequestModel
    {
        [Range(1, int.MaxValue)]
        [FromRoute(Name = "categoryId")]
        public int CategoryId { get; set; }
    }
}
