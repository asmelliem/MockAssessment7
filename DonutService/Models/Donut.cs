﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockAssessment7.DonutService.Models
{
    public class Donut
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public string Photo { get; set; }
        public List<string> Extras { get; set; }
    }
}
