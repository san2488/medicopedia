using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DomainClassLayer
{
    public class Comments
    {
        private int? commentId;
        private int? adviceId;
        private string username;
        private string commentsField;
        private DateTime? commentDateTime;

        public int? CommentId
        {
            get { return commentId; }
            set { commentId = value; }
        }
        public int? AdviceId
        {
            get { return adviceId; }
            set { adviceId = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string CommentsField
        {
            get { return commentsField; }
            set { commentsField = value; }
        }
        public DateTime? CommentDateTime
        {
            get { return commentDateTime; }
            set { commentDateTime = value; }
        }

    }
}
