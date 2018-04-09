using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bwc_report.Models
{
    public class Evaluation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Ratings { get; set; }
        public int AgeMin { get; set; }
        public int AgeMax { get; set; }
        public decimal ValueMin { get; set; }
        public decimal ValueMax { get; set; }
    }
}