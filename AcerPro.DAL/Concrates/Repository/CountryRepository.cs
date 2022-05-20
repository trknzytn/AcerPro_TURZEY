using AcerPro.DAL.Abstracts.Repository;
using AcerPro.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcerPro.DAL.Concrates.Repository
{
    public class CountryRepository : EntityRepository<Country>, ICountryRepository
    {
        DbContext context;
        public CountryRepository(DbContext context_) : base(context_)
        {
            this.context = context_;
        }





    }
}
