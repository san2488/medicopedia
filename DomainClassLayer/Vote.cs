using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DomainClassLayer
{
    public class Vote
    {
        private int? voteId;
        private int? adviceId;
        private string username;
        private bool? isliked;

        public int? VoteId
        {
            get { return voteId; }
            set { voteId = value; }
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
        public bool? Isliked
        {
            get { return isliked; }
            set { isliked = value; }
        }

    }
}
