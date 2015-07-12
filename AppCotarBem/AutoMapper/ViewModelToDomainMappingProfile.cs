
using AppCotarBem.Domain;
using AppCotarBem.Domain.Entities;
using AppCotarBem.ViewModels;
using AutoMapper;

namespace AppCotarBem.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<Produto, ProdutoViewModel>();
        }
    }
}