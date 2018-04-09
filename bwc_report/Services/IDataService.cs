using bwc_report.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bwc_report.Services
{
    public interface IDataService
    {
        BioPhysicalAssessment GetBioPhysicalAssessment(long paadmRowId);
    }
}
