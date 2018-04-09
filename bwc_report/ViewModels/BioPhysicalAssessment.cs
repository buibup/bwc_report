using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bwc_report.ViewModels
{
    public class BioPhysicalAssessment
    {
        public decimal Cardiorespiratory { get; set; }
        public decimal MuscleStrength { get; set; }
        public decimal Flexibility { get; set; }
        public decimal MuscleEndurance { get; set; }
        public decimal AnaerobicPower { get; set; }
        public decimal Agility { get; set; }
    }
}