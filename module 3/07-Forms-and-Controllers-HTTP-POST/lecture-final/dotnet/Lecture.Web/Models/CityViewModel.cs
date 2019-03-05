using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lecture.Web.Models
{
    [Serializable]
    public class CityViewModel
    {
        public string CountryCode { get; set; }
        public string District { get; set; }
    }
}
