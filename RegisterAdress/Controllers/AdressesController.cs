using RegisterAdress.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace RegisterAdress.Controllers
{
    public class AdressesController : ApiController
    {
        private static List<Adress> adresses = new List<Adress>();

        [HttpGet]
        public List<Adress> GetList()
        {
            return adresses;
        }

        [HttpPost]
        public void PostAdress(string street, string number, string district, string city, string uf)
        {
            if ((!string.IsNullOrEmpty(street)) && (!string.IsNullOrEmpty(number)) && (!string.IsNullOrEmpty(district)) && (!string.IsNullOrEmpty(city)) && (!string.IsNullOrEmpty(uf)))
                adresses.Add(new Adress(street, number, district, city, uf));
        }

        [HttpDelete]
        public void DeleteAdress(string street)
        {
            adresses.RemoveAt(adresses.IndexOf(adresses.First(x => x.Street.Equals(street))));
        }
    }
}
