using AutoMapper;
using Core.BusinessModels;
using Core.BusinessModels.Command;
using Core.DBModels;

namespace SithecAPI.Profiles
{
    public class AutoMapping : Profile
    {
        public AutoMapping() 
        {
            CreateMap<HumanCommand, Human>();
            CreateMap<Human, HumanDTO>();
        }
    }
}
