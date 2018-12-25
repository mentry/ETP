using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETP.Models
{
    public class Travel
    {
        public int TravelId { get; set; }
        public string Title { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public int Duration { get; set; }
        
    }
}
