﻿namespace Shop.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public ICollection<HotelComment> HotelComments { get; set; }
    }
}
