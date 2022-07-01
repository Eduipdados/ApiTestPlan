using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AutoMapper;
using Api.Application.ViewModels;
using Api.Domain.Models;
using Api.Application.ViewModels.Produto;

namespace Api.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {

            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
           
        }
    }
}
