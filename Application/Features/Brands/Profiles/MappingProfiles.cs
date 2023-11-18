using Application.Features.Brands.Commands.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entitities;
using AutoMapper;
using Core.Persistence.Paging;
using Core.Application.Responses;
using Application.Features.Brands.Queries.GetList;
using Application.Features.Brands.Queries.GetById;

namespace Application.Features.Brands.Profiles;

public class MappingProfiles:Profile
{

    public MappingProfiles()
    {
        CreateMap<Brand, CreateBrandCommand>().ReverseMap();
        CreateMap<Brand,CreatedBrandResponse>().ReverseMap();
        CreateMap<Brand, GetListBrandListItemDto>().ReverseMap();
        CreateMap<Paginate<Brand>, GetListResponse<GetListBrandListItemDto>>().ReverseMap();
        CreateMap<Brand, GetByIdBrandResponse>().ReverseMap();


    }
}
