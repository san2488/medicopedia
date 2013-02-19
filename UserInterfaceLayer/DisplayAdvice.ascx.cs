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
using BusinessClassLayer;
using DataClassLayer;
using DomainClassLayer;

public partial class DisplayAdvice : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GetQuery();
        GetAdvice();
        GetComments();
        bool result = isCastVote();
        if (result == false)
        {
            PlaceHolder1.Visible = false;
        }
        lblXml.Visible = false;
        if (bool.Parse(Session["SignedIn"].ToString())==false)
        {
            Response.Redirect("index.aspx");
        }
        else if (Session["Role"].ToString() == "1")
        {
            ImageButton1.Visible = false;
        }

       
    }

    public void GetAdvice()
    {
        string connectionString = ConfigurationManager.AppSettings.Get("connString");
        Advice adviceObj = new Advice();
        adviceObj.AdviceId = int.Parse(Session["AdviceId"].ToString());
        BusinessLayer businessLayerObj = new BusinessLayer();
        DataSet dsAdvice = businessLayerObj.SelectAdvice(adviceObj, connectionString);
        lblAdvice.Text = dsAdvice.Tables[0].Rows[0][0].ToString();
        lblAdviceUser.Text= dsAdvice.Tables[0].Rows[0][2].ToString();
        lblLikes.Text = dsAdvice.Tables[0].Rows[0][3].ToString();
        lblDislikes.Text = dsAdvice.Tables[0].Rows[0][4].ToString();
        lblAdviceTitle.Text = dsAdvice.Tables[0].Rows[0][5].ToString();
        lblPosted.Text = dsAdvice.Tables[0].Rows[0][6].ToString();
    }

    public void GetQuery()
    {
        string connectionString = ConfigurationManager.AppSettings.Get("connString");
        Query queryObj = new Query();
        queryObj.QueryId = int.Parse(Session["QueryId"].ToString());
        BusinessLayer businessLayerObj = new BusinessLayer();
        DataSet dsQuery = businessLayerObj.SelectQuery(queryObj, connectionString);
        lblAreaOfInterest.Text = dsQuery.Tables[0].Rows[0][0].ToString();
        lblSymptoms.Text = dsQuery.Tables[0].Rows[0][1].ToString();
        lblMedHistory.Text = dsQuery.Tables[0].Rows[0][2].ToString();
        lblPostedBy.Text = dsQuery.Tables[0].Rows[0][3].ToString();
        lblpostedOn.Text = dsQuery.Tables[0].Rows[0][4].ToString();
    }

    public void GetComments()
    {
        string connectionString = ConfigurationManager.AppSettings.Get("connString");
        Comments commentObj = new Comments();
        commentObj.AdviceId = int.Parse(Session["AdviceId"].ToString());
        BusinessLayer businessLayerObj = new BusinessLayer();
        DataSet dsComment = businessLayerObj.SelectComment(commentObj, connectionString);
        gvShowComments.DataSource = dsComment;
        gvShowComments.DataBind();
    }
    protected void btnGiveComment_Click(object sender, EventArgs e)
    {
        Response.Redirect("CommentOnAdvice.aspx");
    }

    public bool isCastVote()
    {
        DateTime posted = DateTime.Parse(lblPosted.Text);
        double difference = (DateTime.Now - posted).TotalDays;
        if (Convert.ToInt32(difference) < 10)
        {
            return true;
        }
        else
        {

            return false;
        }
    }
    protected void btnGetXML_Click(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.AppSettings.Get("connString");
        Advice adviceObj = new Advice();
        adviceObj.AdviceId = int.Parse(Session["AdviceId"].ToString());
        BusinessLayer businessLayerObj = new BusinessLayer();
        DataSet dsXmlDetails = businessLayerObj.GetXmlDetails(adviceObj, connectionString);
        dsXmlDetails.WriteXml(@"D:\AdviceInfo.xml", XmlWriteMode.WriteSchema);
        lblXml.Visible = true;
    }
    protected void gvShowComments_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvShowComments.PageIndex = e.NewPageIndex;
        GetComments();
    }
    protected void gvShowComments_RowDataBound(object sender, GridViewRowEventArgs e)
    {
         if (Session["Role"].ToString() == "0")
        {
            foreach (GridViewRow row in gvShowComments.Rows)
            {
                ((HyperLink)row.FindControl("HyperLink1")).Visible = false;
            }
        }
    }
}
