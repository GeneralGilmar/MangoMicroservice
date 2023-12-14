using AutoMapper;
using Mango.Services.CouponApi.Models;
using Mango.Services.CouponApi.Models.Dto;

namespace Mango.Services.CouponApi.Infrastructure
{
    public class MangoServiceCouponProfile : Profile
    {
        public MangoServiceCouponProfile()
        {

            CreateMap<Coupon,CouponDto>().ReverseMap();
        }
    }
}
