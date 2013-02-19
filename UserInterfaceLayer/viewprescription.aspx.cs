using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class viewprescription : System.Web.UI.Page
{
    int count = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        string medicinepr1=Convert.ToString(Session["medpr1"]);
        string medicinepr2 = Convert.ToString(Session["medpr2"]);
        string medicinepr3 = Convert.ToString(Session["medpr3"]);
        string medicinepr4 = Convert.ToString(Session["medpr4"]);
        string medicinepr5 = Convert.ToString(Session["medpr5"]);
        string medicinepr6 = Convert.ToString(Session["medpr6"]);
        string medicinepr7 = Convert.ToString(Session["medpr7"]);
        string medicinepr8 = Convert.ToString(Session["medpr8"]);
        string medicinepr9 = Convert.ToString(Session["medpr9"]);
        string medicinepr10 = Convert.ToString(Session["medpr10"]);

        String abc = "true";

        if (medicinepr1.Equals(abc))
        {
            Medicine1Panel.Visible = true;
            sr1.Text = "1";
            m1.Text = Convert.ToString(Session["Med1"]);
            br1.Text = Convert.ToString(Session["DosageBreakfast1"]);
            lu1.Text = Convert.ToString(Session["DosageLunch1"]);
            di1.Text = Convert.ToString(Session["DosageDinner1"]);
            nod1.Text = Convert.ToString(Session["Days1"]);
            not1.Text = Convert.ToString(Session["Tablets1"]);
            count++;
        }

        if (medicinepr2.Equals(abc))
        {
            Medicine2Panel.Visible = true;
            sr2.Text = "2";
            m2.Text = Convert.ToString(Session["Med2"]);
            br2.Text = Convert.ToString(Session["DosageBreakfast2"]);
            lu2.Text = Convert.ToString(Session["DosageLunch2"]);
            di2.Text = Convert.ToString(Session["DosageDinner2"]);
            nod2.Text = Convert.ToString(Session["Days2"]);
            not2.Text = Convert.ToString(Session["Tablets2"]);
            count++;
        }

        if (medicinepr3.Equals(abc))
        {
            Medicine3Panel.Visible = true;
            sr3.Text = "3";
            m3.Text = Convert.ToString(Session["Med3"]);
            br3.Text = Convert.ToString(Session["DosageBreakfast3"]);
            lu3.Text = Convert.ToString(Session["DosageLunch3"]);
            di3.Text = Convert.ToString(Session["DosageDinner3"]);
            nod3.Text = Convert.ToString(Session["Days3"]);
            not3.Text = Convert.ToString(Session["Tablets3"]);
            count++;
        }

        if (medicinepr4.Equals(abc))
        {
            Medicine4Panel.Visible = true;
            sr4.Text = "4";
            m4.Text = Convert.ToString(Session["Med4"]);
            br4.Text = Convert.ToString(Session["DosageBreakfast4"]);
            lu4.Text = Convert.ToString(Session["DosageLunch4"]);
            di4.Text = Convert.ToString(Session["DosageDinner4"]);
            nod4.Text = Convert.ToString(Session["Days4"]);
            not4.Text = Convert.ToString(Session["Tablets4"]);
            count++;
        }

        if (medicinepr5.Equals(abc))
        {
            Medicine5Panel.Visible = true;
            sr5.Text = "5";
            m5.Text = Convert.ToString(Session["Med5"]);
            br5.Text = Convert.ToString(Session["DosageBreakfast5"]);
            lu5.Text = Convert.ToString(Session["DosageLunch5"]);
            di5.Text = Convert.ToString(Session["DosageDinner5"]);
            nod5.Text = Convert.ToString(Session["Days5"]);
            not5.Text = Convert.ToString(Session["Tablets5"]);
            count++;
        }

        if (medicinepr6.Equals(abc))
        {
            Medicine6Panel.Visible = true;
            sr6.Text = "6";
            m6.Text = Convert.ToString(Session["Med6"]);
            br6.Text = Convert.ToString(Session["DosageBreakfast6"]);
            lu6.Text = Convert.ToString(Session["DosageLunch6"]);
            di6.Text = Convert.ToString(Session["DosageDinner6"]);
            nod6.Text = Convert.ToString(Session["Days6"]);
            not6.Text = Convert.ToString(Session["Tablets6"]);
            count++;
        }

        if (medicinepr7.Equals(abc))
        {
            Medicine7Panel.Visible = true;
            sr7.Text = "7";
            m7.Text = Convert.ToString(Session["Med7"]);
            br7.Text = Convert.ToString(Session["DosageBreakfast7"]);
            lu7.Text = Convert.ToString(Session["DosageLunch7"]);
            di7.Text = Convert.ToString(Session["DosageDinner7"]);
            nod7.Text = Convert.ToString(Session["Days7"]);
            not7.Text = Convert.ToString(Session["Tablets7"]);
            count++;
        }

        if (medicinepr8.Equals(abc))
        {
            Medicine8Panel.Visible = true;
            sr8.Text = "8";
            m8.Text = Convert.ToString(Session["Med8"]);
            br8.Text = Convert.ToString(Session["DosageBreakfast8"]);
            lu8.Text = Convert.ToString(Session["DosageLunch8"]);
            di8.Text = Convert.ToString(Session["DosageDinner8"]);
            nod8.Text = Convert.ToString(Session["Days8"]);
            not8.Text = Convert.ToString(Session["Tablets8"]);
            count++;
        }

        if (medicinepr9.Equals(abc))
        {
            Medicine9Panel.Visible = true;
            sr9.Text = "9";
            m9.Text = Convert.ToString(Session["Med9"]);
            br9.Text = Convert.ToString(Session["DosageBreakfast9"]);
            lu9.Text = Convert.ToString(Session["DosageLunch9"]);
            di9.Text = Convert.ToString(Session["DosageDinner9"]);
            nod9.Text = Convert.ToString(Session["Days9"]);
            not9.Text = Convert.ToString(Session["Tablets9"]);
            count++;
        }
        
        if (medicinepr10.Equals(abc))
        {
            Medicine10Panel.Visible = true;
            sr10.Text = "10";
            m10.Text = Convert.ToString(Session["Med10"]);
            br10.Text = Convert.ToString(Session["DosageBreakfast10"]);
            lu10.Text = Convert.ToString(Session["DosageLunch10"]);
            di10.Text = Convert.ToString(Session["DosageDinner10"]);
            nod10.Text = Convert.ToString(Session["Days10"]);
            not10.Text = Convert.ToString(Session["Tablets10"]);
            count++;
        }        
        
    }

    protected void Edit_Click(object sender, EventArgs e)
    {
        Response.Redirect("prescribe.aspx");
    }

    protected void Save_Click(object sender, EventArgs e)
    {
        string recievesms = Convert.ToString(Session["sms"]);
        int revisit = Convert.ToInt32(Session["Revisit"]);

        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Anand\Desktop\sftmed\sftmed\App_Data\ASPNETDB.MDF; Integrated Security=True;User Instance=True");
        SqlCommand cmd = cn.CreateCommand();
        cn.Open();

        cmd.CommandText = "insert into prescriptions (date,doctorid,patientid,revisit,smsreminder) values (getdate(),1,1,DATEADD(d," + revisit + ",getdate()),'" + recievesms + "')";
        cmd.ExecuteNonQuery();

        cmd.CommandText = "select max(prescriptionid) from prescriptions";
        int temp = (int)(cmd.ExecuteScalar());
        

        for (int i = 1; i <= count; i++)
        {
            cmd.CommandText = "insert into prescribedmedicine (prescriptionid,medicinename,dosagebreakfast,dosagelunch,dosagedinner,days,numberoftablets) values ('"+temp+"','" + Session["Med" + i] + "','" + Session["DosageBreakfast" + i] + "','" + Session["DosageLunch" + i] + "','" + Session["DosageDinner" + i] + "','" + Session["Days" + i] + "','" + Session["Tablets" + i] + "')";
            cmd.ExecuteNonQuery();
        }

        cn.Close();
    }
}
