using Albazon.Services.Discounts.Api.Models;
using Albazon.Services.Discounts.Api.Models.Dto;
using AutoMapper;

namespace Albazon.Services.Discounts.Api
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            return new MapperConfiguration(config =>
            {
                config.CreateMap<DiscountDto, Discount>();
            });
        }
    }
}
