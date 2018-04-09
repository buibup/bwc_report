using bwc_report.Models;
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
        string GetMileWalkTest(decimal weight, int age, string gender, TimeSpan time, decimal hr);
        string GetMuscleStrength(decimal weight);
        string GetFlexibility(decimal value);
        string GetMuscleEndurance(TimeSpan time);
        string GetAnaerobicPower(decimal weight);
        string GetAgility(TimeSpan time);
        string GetVitalCapacityPerVC(decimal weight);
    }
}
