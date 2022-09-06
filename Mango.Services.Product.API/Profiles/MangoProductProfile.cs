using AutoMapper;
using Mango.Services.Product.API.Model;
using Mango.Services.Product.API.Model.DTO;

namespace Mango.Services.Product.API.Profiles
{
    public class MangoProductProfile:Profile
    {
        public MangoProductProfile()
        {
            CreateMap<MangoProduct, MangoProductDTO>();
        }
    }
}
