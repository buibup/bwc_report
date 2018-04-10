using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using bwc_report.Models;
using Dapper;
using InterSystems.Data.CacheClient;

namespace bwc_report.DataAccess
{
    public class CacheConnector : ICacheConnection
    {
        private OdbcConnection cache;
        public CacheConnector()
        {
            cache = new OdbcConnection(GlobalConfig.CnnString("Cache"));
        }

        public DataTable GetEprObservatioProcedure(long paadmRowId)
        {
            try
            {
                DataTable dt = new DataTable();
                //string CommandText = "{CALL \"Custom_THSV_Report_ZEN_StoredProc\".\"SVNHSendEmailCSI2_GetData\".('" + dateFrom + "','" + dateTo + "')}";
                string CommandText = "Custom.BWC.Store.BWCEprObservation ('" + paadmRowId + "')}";
                dt = DTBindDataCommand(CommandText, GlobalConfig.CnnString("Cache"));
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static DataTable DTBindDataCommand(string cmdString, string conString)
        {
            DataTable dt = new DataTable();

            using (var con = new CacheConnection(conString))
            {
                using (var adp = new CacheDataAdapter(cmdString, con))
                {
                    adp.Fill(dt);
                }
            }

            return dt;
        }

        public IEnumerable<QBWCBIOPHYA> GetQBWCBIOPHies(long paadmRowId)
        {
            using(var db = cache)
            {
                var data = db.Query<QBWCBIOPHYA>(DbCacheQuery.CmdQBWCBIOPHYByPAAdmDR(), new { QUESPAAdmDR = paadmRowId });
                return data;
            }
        }
    }
}