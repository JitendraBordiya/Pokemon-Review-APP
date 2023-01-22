using AutoMapper;
using PokeReviewApi.Dto;
using PokeReviewApi.Models;
using PokeReviewApi.DTO;

namespace PokeReviewApi.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<Category, CategoryDto>();
            //CreateMap<CategoryDto, Category>();
            //CreateMap<CountryDto, Country>();
            //CreateMap<OwnerDto, Owner>();
            //CreateMap<PokemonDto, Pokemon>();
            //CreateMap<ReviewDto, Review>();
            //CreateMap<ReviewerDto, Reviewer>();
            //CreateMap<Country, CountryDto>();
            //CreateMap<Owner, OwnerDto>();
            //CreateMap<Review, ReviewDto>();
            //CreateMap<Reviewer, ReviewerDto>();
        }
    }
}