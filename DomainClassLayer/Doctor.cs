using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DomainClassLayer
{
    public class Doctor
    {
        private int? docId;
        private string username;
        private string docEmailId;
        private bool? docGender;
        private DateTime? docDateOfBirth;
        private int? docLicenseNo;
        private string docAreaOfInterest;
        private bool? docIsApproved;
        private string docName;

        public int? DocId
        {
            get { return docId; }
            set { docId = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string DocEmailId
        {
            get { return docEmailId; }
            set { docEmailId = value; }
        }
        public bool? DocGender
        {
            get { return docGender; }
            set { docGender = value; }
        }
        public DateTime? DocDateOfBirth
        {
            get { return docDateOfBirth; }
            set { docDateOfBirth = value; }
        }
        public int? DocLicenseNo
        {
            get { return docLicenseNo; }
            set { docLicenseNo = value; }
        }
        public string DocAreaOfInterest
        {
            get { return docAreaOfInterest; }
            set { docAreaOfInterest = value; }
        }
        public bool? DocIsApproved
        {
            get { return docIsApproved; }
            set { docIsApproved = value; }
        }
        public string DocName
        {
            get { return docName; }
            set { docName = value; }
        }
    }
}
