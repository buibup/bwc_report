using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using bwc_report.ViewModels;

namespace bwc_report.Services
{
    public class DataService : IDataService
    {
        public string GetAgility(TimeSpan time)
        {
            throw new NotImplementedException();
        }

        public string GetAnaerobicPower(decimal weight)
        {
            throw new NotImplementedException();
        }

        public BioPhysicalAssessment GetBioPhysicalAssessment(long paadmRowId)
        {
            throw new NotImplementedException();
        }

        public string GetFlexibility(decimal value)
        {
            throw new NotImplementedException();
        }

        public string GetMileWalkTest(decimal weight, int age, string gender, TimeSpan time, decimal hr)
        {
            throw new NotImplementedException();
        }

        public string GetMuscleEndurance(TimeSpan time)
        {
            throw new NotImplementedException();
        }

        public string GetMuscleStrength(decimal weight)
        {
            throw new NotImplementedException();
        }

        public string GetVitalCapacityPerVC(decimal weight)
        {
            throw new NotImplementedException();
        }
    }
}