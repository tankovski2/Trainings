using BuildMyOwnFramework.Domain;
using BuildMyOwnFramework.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildMyOwnFramework.Models.Issue
{
    public class IssueSummaryViewModel : IMapFrom<Domain.Issue>
    {
        public int IssueID { get; set; }
        public string Subject { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatorUserName { get; set; }
        public IssueType IssueType { get; set; }
        public string AssignedToUserName { get; set; }
    }
}