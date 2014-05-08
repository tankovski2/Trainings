using BuildMyOwnFramework.Domain;
using BuildMyOwnFramework.Infrastructure.Mapping;
using BuildMyOwnFramework.Infrastructure.ModelMetadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BuildMyOwnFramework.Models.Issue
{
    public class IssueDetailsViewModel : IMapFrom<Domain.Issue>
    {
        [Render(ShowForEdit = false)]
        public int IssueID { get; set; }

        [Render(ShowForEdit = false)]
        public DateTime CreatedAt { get; set; }

        [ReadOnly(true)]
        public string CreatorUserName { get; set; }

        public string Subject { get; set; }

        public IssueType IssueType { get; set; }

        public string AssignedToUserName { get; set; }

        public string Body { get; set; }
    }
}