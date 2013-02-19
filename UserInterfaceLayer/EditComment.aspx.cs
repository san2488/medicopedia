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

public partial class EditComment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetComment();
            GetAdvice();
        }
    }

    public void GetComment()
    {
        string connectionString = ConfigurationManager.AppSettings.Get("connString");
        Comments commentObj = new Comments();
        commentObj.CommentId = int.Parse(Request.QueryString["CommentId"].ToString());
        BusinessLayer businessObj = new BusinessLayer ();
        DataSet dsComment = businessObj.getComments(commentObj, connectionString);
        txtComment.Text = dsComment.Tables[0].Rows[0][0].ToString();
      
    }

    public void GetAdvice()
    {
        string connectionString = ConfigurationManager.AppSettings.Get("connString");
        Advice adviceObj = new Advice();
        adviceObj.AdviceId = int.Parse(Session["AdviceId"].ToString());
        BusinessLayer businessLayerObj = new BusinessLayer();
        DataSet dsAdvice = businessLayerObj.SelectAdvice(adviceObj, connectionString);
        lblAdvice.Text = dsAdvice.Tables[0].Rows[0][0].ToString();
    }

    public void UpdateComment()
    {
        string connectionString = ConfigurationManager.AppSettings.Get("connString");
        Comments commentObj = new Comments();
        if (txtComment.Text.Equals(string.Empty) == false)
        {
            commentObj.CommentsField = txtComment.Text;
            commentObj.CommentId = int.Parse(Request.QueryString["CommentId"].ToString());
            BusinessLayer businessObj = new BusinessLayer();
            businessObj.UpdateComment(commentObj, connectionString);
            Response.Redirect("VoteAndCommentInfo.aspx");
        }
        else
            lblError.Text = "Blank Comment Cannot Be Submitted";
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        UpdateComment();
    }
}
