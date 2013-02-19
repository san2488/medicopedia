using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace DomainClassLayer
{
    public class Prescriptions
    {
        private int? prescriptionId;
        private string username;
        private DateTime? prescriptionDateTime;
        private int? queryId;

        public int? PrescriptionId
        {
            get { return prescriptionId; }
            set { prescriptionId = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public DateTime? PrescriptionDateTime
        {
            get { return prescriptionDateTime; }
            set { prescriptionDateTime = value; }
        }
        public int? QueryId
        {
            get { return queryId; }
            set { queryId = value; }
        }
    }
}
