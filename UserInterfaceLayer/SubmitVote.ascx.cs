using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using DomainClassLayer;
using BusinessClassLayer;

public partial class SubmitVote : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PlaceHolder2.Visible = false;
    }
    protected void VoteAgainst_Click(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.AppSettings.Get("connString");
        Vote voteObj = new Vote();

        //creating and initializing Vote object

        voteObj.AdviceId = Convert.ToInt32(Session["AdviceId"].ToString());
        voteObj.Username = Session["Username"].ToString();
        voteObj.Isliked = false;

        //passing to business layer
        BusinessLayer businessLayerObj = new BusinessLayer();
        businessLayerObj.InsertVote(voteObj, connectionString);
        PlaceHolder1.Visible = false;
        PlaceHolder2.Visible = true;

    }
    protected void VoteFor_Click(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.AppSettings.Get("connString");
        Vote voteObj = new Vote();

        //creating and initializing Vote object

        voteObj.AdviceId = Convert.ToInt32(Session["AdviceId"].ToString());
        voteObj.Username = Session["Username"].ToString();
        voteObj.Isliked = true;

        //passing to business layer
        BusinessLayer businessLayerObj = new BusinessLayer();
        businessLayerObj.InsertVote(voteObj, connectionString);

        PlaceHolder1.Visible = false;
        PlaceHolder2.Visible = true;

    }
    protected void btnGoBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("QueryHistory.aspx");
    }
}
