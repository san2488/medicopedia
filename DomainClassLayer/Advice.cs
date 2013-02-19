using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DomainClassLayer
{
    public class Advice
    {
        private int? adviceId;
        private int? queryId;
        private string username;
        private int? likes;
        private int? dislikes;
        private string adviceDescription;
        private string adviceTitle;
        private DateTime? adviceDateTime;

        public int? AdviceId
        {
            get { return adviceId; }
            set { adviceId = value; }
        }
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
        public int? Likes
        {
            get { return likes; }
            set { likes = value; }
        }
        public int? Dislikes
        {
            get { return dislikes; }
            set { dislikes = value; }
        }
        public string AdviceDescription
        {
            get { return adviceDescription; }
            set { adviceDescription = value; }
        }
        public string AdviceTitle
        {
            get { return adviceTitle; }
            set { adviceTitle = value; }
        }
        public DateTime? AdviceDateTime
        {
            get { return adviceDateTime; }
            set { adviceDateTime = value; }
        }

    }
}
