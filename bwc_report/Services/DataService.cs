using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using bwc_report.DataAccess;
using bwc_report.ViewModels;

namespace bwc_report.Services
{
    public class DataService : IDataService
    {
        ICacheConnection cache;
        public DataService()
        {
            cache = new CacheConnector();
        }
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
            var biophy = cache.GetQBWCBIOPHies(paadmRowId);
            var obs = cache.GetEprObservatioProcedure(paadmRowId);

            var result = new BioPhysicalAssessment();

            return result;
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