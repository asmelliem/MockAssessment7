using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockAssessment7.Models
{
    public class DonutSearchResult
    {
        public string Name { get; set; }
        public int Calories { get; set; }
        public string PhotoURL { get; set; }
        public List<string> Extras { get; set; }
    }
}
