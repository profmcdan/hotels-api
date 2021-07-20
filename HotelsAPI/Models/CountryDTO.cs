using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelsAPI.Models
{

    public class CreateCountryDto
    {
        [Required]
        [StringLength(maximumLength: 100, ErrorMessage = "Country Name is too long")]
        public string Name { get; set; }
        
        [Required]
        [StringLength(maximumLength: 3, ErrorMessage = "Short Country Name is too long")]
        public string ShortName { get; set; }
    }
    
    public class CountryDto : CreateCountryDto
    {
        public Guid Id { get; set; }
        public virtual IList<HotelDto> Hotels { get; set; }
    }
}