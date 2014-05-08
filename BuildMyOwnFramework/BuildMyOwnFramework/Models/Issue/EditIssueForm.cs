using BuildMyOwnFramework.Domain;
using BuildMyOwnFramework.Filters;
using BuildMyOwnFramework.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuildMyOwnFramework.Models.Issue
{
    public class EditIssueForm : IMapFrom<Domain.Issue>
    {
        [HiddenInput]
        public int IssueID { get; set; }

        [ReadOnly(true)]
        public string CreatorUserName { get; set; }

        [Required]
        public string Subject { get; set; }

        public IssueType IssueType { get; set; }

        [Display(Name = "Assigned To")]
        public string AssignedToUserName { get; set; }

        [Required]
        public string Body { get; set; }
    }
}