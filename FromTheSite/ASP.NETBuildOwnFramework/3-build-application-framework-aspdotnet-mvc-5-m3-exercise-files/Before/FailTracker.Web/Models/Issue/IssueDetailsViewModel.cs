using System;
using FailTracker.Web.Domain;

namespace FailTracker.Web.Models.Issue
{
	public class IssueDetailsViewModel
	{
		public int IssueID { get; set; }
		public string Subject { get; set; }
		public string Creator { get; set; }
		public string AssignedTo { get; set; }
		public DateTime CreatedAt { get; set; }
		public IssueType IssueType { get; set; }
		public string Body { get; set; }
	}
}