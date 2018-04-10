using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bwc_report.Models
{
    public class QBWCBIOPHYA
    {
        public int ID { get; set; }
        public long QUESPAAdmDR { get; set; }
        public int QMHR { get; set; }
        public int QModerateZone6 { get; set; }
        public int QModerateZone7 { get; set; }
        public int QModerateZone8 { get; set; }
        public int QMileWalkTime { get; set; }
        public int QMileWalkHR { get; set; }
        public string QMileWalkSpeed { get; set; }
        public string QPhMuscleStrength { get; set; }
        public int QPhFlexibility { get; set; }
        public int QPhMuscleEndurance { get; set; }
        public string QPhAnaerobicPower { get; set; }
        public int QPhAgility { get; set; }
        public int QPhVitalCapacity { get; set; }
        public int QIsoTrunkFlexion { get; set; }
        public int QIsoTrunkExtension { get; set; }
    }
}