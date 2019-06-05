using AutoMapper;
using Business.Models;
using App.ViewModels;

namespace App.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Sistema, SistemaViewModel>().ReverseMap();
            CreateMap<Avaliacao, AvaliacaoViewModel>().ReverseMap();
        }
    }
}
