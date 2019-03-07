using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lecture.Web.Models
{
    public class City
    {
        //9. Create the city model
        public int CityId { get; set; }

        [Required(ErrorMessage = "*")]
        public string Name { get; set; }

        [Required(ErrorMessage = "*")]
        public string District { get; set; }

        [Required(ErrorMessage = "*")]
        [MaxLength(3, ErrorMessage = "Country code should be 3 characters.")]
        [MinLength(3, ErrorMessage = "Country code should be 3 characters.")]
        public string CountryCode { get; set; }

        [Required(ErrorMessage = "*")]
        public int Population { get; set; }
    }
}
