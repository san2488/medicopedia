using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using DomainClassLayer;
using BusinessClassLayer;

public partial class prescribe : System.Web.UI.Page
{
    int count = 0;
    protected void previewpres_Click(object sender, EventArgs e)
    {

        int nod1, nod2, nod3, nod4, nod5, nod6, max = 0;

        if (M1.Text != "")
        {
            count++;
            Medicine1Panel.Visible = true;
            medname1.Text = M1.Text;
            br1.Text = "";
            if (M1bfbr.Checked == true)
                br1.Text = "Before";
            else if (M1afbr.Checked == true)
                br1.Text = "After";
            lu1.Text = "";
            if (M1bflu.Checked == true)
                lu1.Text = "Before";
            else if (M1aflu.Checked == true)
                lu1.Text = "After";

            di1.Text = "";
            if (M1bfdi.Checked == true)
                di1.Text = "Before";
            else if (M1afdi.Checked == true)
                di1.Text = "After";

            nod1 = 0;
            if (NOD1.Text != "")
                nod1 = Convert.ToInt32(NOD1.Text);
            if (nod1 > max)
                max = nod1;
            days1.Text = NOD1.Text;


            double not1 = 0;
            if (NOT1.Text != "")
                not1 = Convert.ToDouble(NOT1.Text);
            tbt1.Text = NOT1.Text;
        }

        if (M2.Text != "")
        {
            count++;
            Medicine2Panel.Visible = true;
            medname2.Text = M2.Text;

            br2.Text = "";
            if (M2bfbr.Checked == true)
                br2.Text = "Before";
            else if (M2afbr.Checked == true)
                br2.Text = "After";

            lu2.Text = "";
            if (M2bflu.Checked == true)
                lu2.Text = "Before";
            else if (M2aflu.Checked == true)
                lu2.Text = "After";

            di2.Text = "";
            if (M2bfdi.Checked == true)
                di2.Text = "Before";
            else if (M2afdi.Checked == true)
                di2.Text = "After";

            nod2 = 0;
            if (NOD2.Text != "")
                nod2 = Convert.ToInt32(NOD2.Text);
            if (nod2 > max)
                max = nod2;
            days2.Text = NOD2.Text;


            double not2 = 0;
            if (NOT2.Text != "")
                not2 = Convert.ToDouble(NOT2.Text);
            tbt2.Text = NOT2.Text;

        }

        if (M3.Text != "")
        {
            count++;
            Medicine3Panel.Visible = true;
            medname3.Text = M3.Text;

            br3.Text = "";
            if (M3bfbr.Checked == true)
                br3.Text = "Before";
            else if (M3afbr.Checked == true)
                br3.Text = "After";

            lu3.Text = "";
            if (M3bflu.Checked == true)
                lu3.Text = "Before";
            else if (M3aflu.Checked == true)
                lu3.Text = "After";

            di3.Text = "";
            if (M3bfdi.Checked == true)
                di3.Text = "Before";
            else if (M3afdi.Checked == true)
                di3.Text = "After";

            nod3 = 0;
            if (NOD3.Text != "")
                nod3 = Convert.ToInt32(NOD3.Text);
            if (nod3 > max)
                max = nod3;
            days3.Text = NOD3.Text;


            double not3 = 0;
            if (NOT3.Text != "")
                not3 = Convert.ToDouble(NOT3.Text);
            tbt3.Text = NOT3.Text;

        }

        if (M4.Text != "")
        {
            count++;
            Medicine4Panel.Visible = true;
            medname4.Text = M4.Text;

            br4.Text = "";
            if (M4bfbr.Checked == true)
                br4.Text = "Before";
            else if (M4afbr.Checked == true)
                br4.Text = "After";

            lu4.Text = "";
            if (M4bflu.Checked == true)
                lu4.Text = "Before";
            else if (M4aflu.Checked == true)
                lu4.Text = "After";

            di4.Text = "";
            if (M4bfdi.Checked == true)
                di4.Text = "Before";
            else if (M4afdi.Checked == true)
                di4.Text = "After";

            nod4 = 0;
            if (NOD4.Text != "")
                nod4 = Convert.ToInt32(NOD4.Text);
            if (nod4 > max)
                max = nod4;
            days4.Text = NOD4.Text;


            double not4 = 0;
            if (NOT4.Text != "")
                not4 = Convert.ToDouble(NOT4.Text);
            tbt4.Text = NOT4.Text;

        }

        if (M5.Text != "")
        {
            count++;
            Medicine5Panel.Visible = true;
            medname5.Text = M5.Text;

            br5.Text = "";
            if (M5bfbr.Checked == true)
                br5.Text = "Before";
            else if (M5afbr.Checked == true)
                br5.Text = "After";

            lu5.Text = "";
            if (M5bflu.Checked == true)
                lu5.Text = "Before";
            else if (M5aflu.Checked == true)
                lu5.Text = "After";

            di5.Text = "";
            if (M5bfdi.Checked == true)
                di5.Text = "Before";
            else if (M5afdi.Checked == true)
                di5.Text = "After";

            nod5 = 0;
            if (NOD5.Text != "")
                nod5 = Convert.ToInt32(NOD5.Text);
            if (nod5 > max)
                max = nod5;
            days5.Text = NOD5.Text;


            double not5 = 0;
            if (NOT5.Text != "")
                not5 = Convert.ToDouble(NOT5.Text);
            tbt5.Text = NOT5.Text;

        }

        if (M6.Text != "")
        {
            count++;
            Medicine6Panel.Visible = true;
            medname6.Text = M6.Text;

            br6.Text = "";
            if (M6bfbr.Checked == true)
                br6.Text = "Before";
            else if (M6afbr.Checked == true)
                br6.Text = "After";

            lu6.Text = "";
            if (M6bflu.Checked == true)
                lu6.Text = "Before";
            else if (M6aflu.Checked == true)
                lu6.Text = "After";

            di6.Text = "";
            if (M6bfdi.Checked == true)
                di6.Text = "Before";
            else if (M6afdi.Checked == true)
                di6.Text = "After";

            nod6 = 0;
            if (NOD6.Text != "")
                nod6 = Convert.ToInt32(NOD6.Text);
            if (nod6 > max)
                max = nod6;
            days6.Text = NOD6.Text;

            double not6 = 0;
            if (NOT6.Text != "")
                not6 = Convert.ToDouble(NOT6.Text);
            tbt6.Text = NOT6.Text;

        }


        setpres.Visible = false;
        viewpres.Visible = true;


    }

    protected void Edit_Click(object sender, EventArgs e)
    {
        viewpres.Visible = false;
        setpres.Visible = true;
    }

    protected void Save_Click(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.AppSettings.Get("connString");
        //create prescribedMedicineObj object to Intialize 
        BusinessLayer businessLyerObj = new BusinessLayer();
        DomainClassLayer.Prescriptions prescriptionsObj = new DomainClassLayer.Prescriptions();
        prescriptionsObj.PrescriptionDateTime = DateTime.Now;
        prescriptionsObj.QueryId = int.Parse(queryId.Text);
        prescriptionsObj.Username = user.Text;
        prescriptionsObj = businessLyerObj.InsertPrescription(prescriptionsObj, connectionString);

        if (M1.Text != "")
        {
            PrescribedMedicine prescribedMedicineObj1 = new PrescribedMedicine();
            prescribedMedicineObj1.MedicineName = M1.Text ?? null;
            prescribedMedicineObj1.DosageBreakfast = (br1.Text);
            prescribedMedicineObj1.DosageLunch = (lu1.Text);
            prescribedMedicineObj1.DosageDinner = (di1.Text);
            prescribedMedicineObj1.Days = int.Parse(NOD1.Text);
            prescribedMedicineObj1.NumberOfTablets = int.Parse(NOT1.Text);
            prescribedMedicineObj1.PrescriptionId = prescriptionsObj.PrescriptionId;

            prescribedMedicineObj1 = businessLyerObj.InsertPrescribedMedicine(prescribedMedicineObj1, connectionString);
        }

        if (M2.Text != "")
        {
            DomainClassLayer.PrescribedMedicine prescribedMedicineObj2 = new DomainClassLayer.PrescribedMedicine();
            prescribedMedicineObj2.MedicineName = M2.Text ?? null;
            prescribedMedicineObj2.DosageBreakfast = (br2.Text);
            prescribedMedicineObj2.DosageLunch = (lu2.Text);
            prescribedMedicineObj2.DosageDinner = (di2.Text);
            prescribedMedicineObj2.Days = int.Parse(NOD2.Text);
            prescribedMedicineObj2.NumberOfTablets = int.Parse(NOT2.Text);
            prescribedMedicineObj2 = businessLyerObj.InsertPrescribedMedicine(prescribedMedicineObj2, connectionString);

        }

        if (M3.Text != "")
        {
            PrescribedMedicine prescribedMedicineObj3 = new PrescribedMedicine();
            prescribedMedicineObj3.MedicineName = M3.Text ?? null;
            prescribedMedicineObj3.DosageBreakfast = (br3.Text);
            prescribedMedicineObj3.DosageLunch = (lu3.Text);
            prescribedMedicineObj3.DosageDinner = (di3.Text);
            prescribedMedicineObj3.Days = int.Parse(NOD3.Text);
            prescribedMedicineObj3.NumberOfTablets = int.Parse(NOT3.Text);
            prescribedMedicineObj3 = businessLyerObj.InsertPrescribedMedicine(prescribedMedicineObj3, connectionString);

        }

        if (M4.Text != "")
        {
            PrescribedMedicine prescribedMedicineObj4 = new PrescribedMedicine();
            prescribedMedicineObj4.MedicineName = M4.Text ?? null;
            prescribedMedicineObj4.DosageBreakfast = (br4.Text);
            prescribedMedicineObj4.DosageLunch = (lu4.Text);
            prescribedMedicineObj4.DosageDinner = (di4.Text);
            prescribedMedicineObj4.Days = int.Parse(NOD4.Text);
            prescribedMedicineObj4.NumberOfTablets = int.Parse(NOT4.Text);
            prescribedMedicineObj4 = businessLyerObj.InsertPrescribedMedicine(prescribedMedicineObj4, connectionString);

        }

        if (M5.Text != "")
        {
            PrescribedMedicine prescribedMedicineObj5 = new PrescribedMedicine();
            prescribedMedicineObj5.MedicineName = M5.Text ?? null;
            prescribedMedicineObj5.DosageBreakfast = (br5.Text);
            prescribedMedicineObj5.DosageLunch = (lu5.Text);
            prescribedMedicineObj5.DosageDinner = (di5.Text);
            prescribedMedicineObj5.Days = int.Parse(NOD5.Text);
            prescribedMedicineObj5.NumberOfTablets = int.Parse(NOT5.Text);
            prescribedMedicineObj5 = businessLyerObj.InsertPrescribedMedicine(prescribedMedicineObj5, connectionString);

        }

        if (M6.Text != "")
        {
            PrescribedMedicine prescribedMedicineObj6 = new PrescribedMedicine();
            prescribedMedicineObj6.MedicineName = M6.Text ?? null;
            prescribedMedicineObj6.DosageBreakfast = (br6.Text);
            prescribedMedicineObj6.DosageLunch = (lu6.Text);
            prescribedMedicineObj6.DosageDinner = (di6.Text);
            prescribedMedicineObj6.Days = int.Parse(NOD6.Text);
            prescribedMedicineObj6.NumberOfTablets = int.Parse(NOT6.Text);
            prescribedMedicineObj6 = businessLyerObj.InsertPrescribedMedicine(prescribedMedicineObj6, connectionString);

        }

        Response.Redirect("thankpres.aspx");

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        queryId.Text = Request.QueryString["QueryId"].ToString();
        user.Text = User.Identity.Name;
    }
}
