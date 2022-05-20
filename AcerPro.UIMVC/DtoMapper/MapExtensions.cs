using AcerPro.Model;
using AutoMapper;
using System;

namespace AcerPro.UIMVC.DtoMapper
{
    public static class MapExtensions
    {
        public static CountryDto ToModel(this Country entity)
        {
            return Mapper.Map<Country, CountryDto>(entity);
        }

        public static Country ToEntity(this CountryDto model)
        {

            try
            {
                var test = Mapper.Map<CountryDto, Country>(model);
                return test;
            }
            catch (Exception ex)
            {
                return new Country()
                {
                     CapitalCity = model.CapitalCity, 
                     CountryCurrency=model.CountryCurrency, 
                     CountryISOCode=model.CountryISOCode,
                     CountryName = model.CountryName
                };
            }

        }


    }
}