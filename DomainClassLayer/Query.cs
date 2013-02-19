using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DomainClassLayer
{
    public class Query
    {
        private int? queryId;
        private string username;
        private string queryAreaOfInterest;
        private string symptoms;
        private string medicalHistory;
        private string status;
        private bool? isAttendedTo;
        private DateTime? postedDatetime;

        public int? QueryId
        {
            get { return queryId; }
            set { queryId = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string QueryAreaOfInterest
        {
            get { return queryAreaOfInterest; }
            set { queryAreaOfInterest = value; }
        }
        public string Symptoms
        {
            get { return symptoms; }
            set { symptoms = value; }
        }
        public string MedicalHistory
        {
            get { return medicalHistory; }
            set { medicalHistory = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public bool? IsAttendedTo
        {
            get { return isAttendedTo; }
            set { isAttendedTo = value; }
        }
        public DateTime? PostedDatetime
        {
            get { return postedDatetime; }
            set { postedDatetime = value; }
        }


    }
}
