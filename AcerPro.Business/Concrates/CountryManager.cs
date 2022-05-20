using AcerPro.Business.Abstracts;
using AcerPro.DAL.Concrates.Repository;
using AcerPro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AcerPro.Business.Concrates
{
    public class CountryManager : IManager<Country>
    {
        CountryRepository _countryRepository;
        public CountryManager(CountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public void Add(Country entity)
        {
            _countryRepository.Add(entity);
        }

        public IEnumerable<Country> Find(Expression<Func<Country, bool>> predicate)
        {
            return _countryRepository.Find(predicate);
        }

        public IEnumerable<Country> GetAll()
        {
             return _countryRepository.GetAll();
        }

        public Task<IEnumerable<Country>> GetAllAsync()
        {
            return _countryRepository.GetAllAsync();
        }

        public Country GetById(int id)
        {
            return _countryRepository.GetById(id);
        }

        public void Remove(Country entity)
        {
             _countryRepository.Remove(entity);
        }

        public void Update(Country entitiy, int id)
        {
            _countryRepository.Update(entitiy, id);
        }
    }
}
