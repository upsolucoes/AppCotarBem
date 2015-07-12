
using AppCotarBem.Domain;
using AppCotarBem.Domain.Entities;
using AppCotarBem.ViewModels;
using AutoMapper;

namespace AppCotarBem.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ProdutoViewModel, Produto>();
        }
    }
}