using bwc_report.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bwc_report.ViewModels
{
    public class BioPhysicalAssessment
    {
        public decimal Cardiorespiratory { get; set; }
        public BioGeneral General { get; set; }
        public BioMileWalkTest MBioMileWalkTestyProperty { get; set; }
        public BioPhysicalTest BioPhysicalTest { get; set; }
        public BioIsometricTest BioIsometricTest { get; set; }
    }
}