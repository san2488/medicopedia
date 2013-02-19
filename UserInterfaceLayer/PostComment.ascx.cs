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
using DataClassLayer;

public partial class PostComment : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.AppSettings.Get("connString");
        Advice adviceObj = new Advice();
        adviceObj.AdviceId = int.Parse(Session["AdviceId"].ToString());
        BusinessLayer businessLayerObj = new BusinessLayer();
        DataSet dsAdvice = businessLayerObj.SelectAdvice(adviceObj, connectionString);
        lblAdvice.Text = dsAdvice.Tables[0].Rows[0][0].ToString();
        
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            SaveComment();
            Response.Redirect("VoteAndCommentInfo.aspx");
        }
        catch
        {
            throw;
        }
    }

    protected void SaveComment()
    {
        string connectionString = ConfigurationManager.AppSettings.Get("connString");
        Comments comment = new Comments();
        comment.CommentDateTime = DateTime.Now;
        comment.Username = Session["Username"].ToString();
        comment.AdviceId = int.Parse(Session["AdviceId"].ToString());
        comment.CommentsField = txtComment.Text;
        BusinessLayer businessLayerObj = new BusinessLayer();
        businessLayerObj.InsertComment(comment, connectionString);
    }
}
