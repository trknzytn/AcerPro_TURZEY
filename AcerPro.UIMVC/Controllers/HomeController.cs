using AcerPro.Business;
using AcerPro.Business.Concrates;
using AcerPro.DAL.Concrates.EF;
using AcerPro.DAL.Concrates.Repository;
using AcerPro.Model;
using AcerPro.UIMVC.DtoMapper;
using System.Web.Mvc;

namespace AcerPro.UIMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly CountryManager countryManager = new CountryManager(new CountryRepository(new AcerContext()));
        public ActionResult Index()
        {
            CountryInfoManager countryInfoManager = new CountryInfoManager();
            var listOfCountryNames = countryInfoManager.ListOfCountryNamesByCode();
            
            return View(listOfCountryNames);
        }

        [HttpPost]
        public ActionResult GetCountry(string code)
        {
            CountryInfoManager countryInfoManager = new CountryInfoManager();
            string countryISOCode = code;
            string capitalCity = countryInfoManager.CapitalCity(code);
            var countryCurrency = countryInfoManager.CountryCurrency(code);
            string countryISOCode_ = countryInfoManager.CountryISOCode(""); 

            CountryDto  countryDto = new CountryDto();
            countryDto.CountryISOCode = code;
            countryDto.CountryName = countryISOCode;
            countryDto.CountryCurrency = countryCurrency.sName;
            countryDto.CapitalCity = capitalCity;

            return Json(countryDto, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Save(CountryDto Country)
        {
            countryManager.Add(Country.ToEntity());
            var countryListSaved= countryManager.GetAll();

            //CountryListSaved.Add(Country);
            return Json(countryListSaved, JsonRequestBehavior.AllowGet);
        }



    }
}