using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bwc_report.Models
{
    public class BioGeneral
    {
        public DateTime Date { get; set; }
        public string HN { get; set; }
        public string NameSurname { get; set; }
        public DateTime Dob { get; set; }
        public int Age { get; set; }
        public decimal Weight { get; set; }
        public string WeightUnit { get; set; }
        public decimal Height { get; set; }
        public string HeightUnit { get; set; }
        public string RestingHR { get; set; }
        public decimal BP { get; set; }
        public decimal MHR { get; set; }
        public decimal ModerateZone { get; set; }
    }
}