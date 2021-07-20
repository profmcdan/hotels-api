using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelsAPI.Data
{
    public class Hotel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }
        
        [ForeignKey(nameof(Country))]
        public Guid CountryId { get; set; }
        public Country Country { get; set; }
    }
}