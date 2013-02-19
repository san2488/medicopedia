using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DomainClassLayer
{
    public class PrescribedMedicine
    {
        private int? prescriptionId;
        private string medicineName;
        private string dosageBreakfast;
        private string dosageLunch;
        private string dosageDinner;
        private int? days;
        private int? numberOfTablets;
        private int? medicineId;

        public int? PrescriptionId
        {
            get { return prescriptionId; }
            set { prescriptionId = value; }
        }
        public string MedicineName
        {
            get { return medicineName; }
            set { medicineName = value; }
        }
        public string DosageBreakfast
        {
            get { return dosageBreakfast; }
            set { dosageBreakfast = value; }
        }
        public string DosageLunch
        {
            get { return dosageLunch; }
            set { dosageLunch = value; }
        }
        public string DosageDinner
        {
            get { return dosageDinner; }
            set { dosageDinner = value; }
        }
        public int? Days
        {
            get { return days; }
            set { days = value; }
        }
        public int? NumberOfTablets
        {
            get { return numberOfTablets; }
            set { numberOfTablets = value; }
        }
        public int? MedicineId
        {
            get { return medicineId; }
            set { medicineId = value; }
        }

    }
}
