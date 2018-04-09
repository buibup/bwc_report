using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using bwc_report.Models;
using Dapper;
using InterSystems.Data.CacheClient;

namespace bwc_report.DataAccess
{
    public class CacheConnector : ICacheConnection
    {
        private CacheConnection cache;
        public CacheConnector()
        {
            cache = new CacheConnection(GlobalConfig.CnnString("Cache"));
        }
        public IEnumerable<QBWCBIOPHY> GetQBWCBIOPHies(long paadmRowId)
        {
            using(var db = cache)
            {
                var data = db.Query<QBWCBIOPHY>(DbCacheQuery.GetQBWCBIOPHYByPAAdmDR(), new { QUESPAAdmDR = paadmRowId });
                return data;
            }
        }
    }
}