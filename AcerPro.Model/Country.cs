using System.ComponentModel.DataAnnotations;

namespace AcerPro.Model
{
    public class Country
    {
        [Key]
        public int ID { get; set; }
        public string CountryISOCode { get; set; }
        public string CountryName { get; set; }
        public string CapitalCity { get; set; }
        public string CountryCurrency { get; set; }
    }
}
