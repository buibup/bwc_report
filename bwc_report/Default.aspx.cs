using bwc_report.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bwc_report
{
    public partial class Default : System.Web.UI.Page
    {
        private IDataService service;
        public Default()
        {
            service = new DataService();
        }
 
        protected void Page_Load(object sender, EventArgs e)
        {
            long paadmRowId = 1021;
            service.GetBioPhysicalAssessment(paadmRowId);
        }
    }
}