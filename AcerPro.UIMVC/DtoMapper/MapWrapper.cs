using AcerPro.Model;
using AutoMapper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcerPro.UIMVC.DtoMapper
{
    public class MapWrapper
    {
        public static void Run()
        {
            SetMappings();
        }

        private static void SetMappings()
        {
            var config = new MapperConfigurationExpression();
            config.CreateMap<Country, CountryDto>();
            config.CreateMap<CountryDto, Country>();
        }
    }
}