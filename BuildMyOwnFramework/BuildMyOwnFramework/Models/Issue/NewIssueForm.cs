using BuildMyOwnFramework.Domain;
using BuildMyOwnFramework.Filters;
using BuildMyOwnFramework.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuildMyOwnFramework.Models.Issue
{
    public class NewIssueForm 
    {
        [Required]
        public string Subject { get; set; }

        [Required]
        public IssueType IssueType { get; set; }

        [Required, Display(Name = "Assigned To")]
        public string AssignedToUserID { get; set; }

        [Required]
        public string Body { get; set; }
    }
}