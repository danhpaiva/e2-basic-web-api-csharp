namespace RegisterAdress.Models
{
    public class Adress
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string UF { get; set; }

        public Adress(string street, string number, string district, string city, string uf)
        {
            this.Street = street;
            this.Number = number;
            this.District = district;
            this.City = city;
            this.UF = uf;
        }
    }
}