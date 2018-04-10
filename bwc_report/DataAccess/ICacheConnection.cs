using bwc_report.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bwc_report.DataAccess
{
    public interface ICacheConnection
    {
        IEnumerable<QBWCBIOPHYA> GetQBWCBIOPHies(long paadmRowId);
        DataTable GetEprObservatioProcedure(long paadmRowId);
    }
}
