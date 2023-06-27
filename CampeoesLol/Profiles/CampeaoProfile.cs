using AutoMapper;
using CampeoesLol.Data.Dtos;
using CampeosLol.Models;

namespace CampeoesLol.Profiles
{
    public class CampeaoProfile : Profile
    {
        public CampeaoProfile()
        {
            CreateMap<CreateCampeaoDto, Campeao>();
        }
    }
}
