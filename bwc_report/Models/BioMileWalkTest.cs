using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bwc_report.Models
{
    public class BioMileWalkTest
    {
        public TimeSpan Time{ get; set; }
        public string TimeUnit { get; set; }
        public decimal HR { get; set; }
        public string HRUnit { get; set; }
        public decimal SpeedMax { get; set; }
    }
}