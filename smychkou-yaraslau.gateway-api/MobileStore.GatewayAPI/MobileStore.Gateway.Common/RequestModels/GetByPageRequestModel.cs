using System.ComponentModel.DataAnnotations;

namespace MobileStore.Gateway.Common.RequestModels
{
    public class GetByPageRequestModel
    {
        [Range(1, int.MaxValue)]
        public int? LastViewedId { get; set; }

        [Required]
        [Range(1, byte.MaxValue)]
        public byte PageSize { get; set; }
    }
}
