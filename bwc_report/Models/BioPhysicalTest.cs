using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bwc_report.Models
{
    public class BioPhysicalTest
    {
        public decimal MuscleStrength { get; set; }
        public string MuscleStrengthUnit { get; set; }
        public decimal Flexibility { get; set; }
        public string FlexibilityUnit { get; set; }
        public decimal MuscleEndurance { get; set; }
        public string MuscleEnduranceUnit { get; set; }
        public decimal AnaerobicPower { get; set; }
        public string AnaerobicPowerUnit { get; set; }
        public decimal VitalCapacityPerVC { get; set; }
        public string VitalCapacityPerVCUnit { get; set; }
    }
}