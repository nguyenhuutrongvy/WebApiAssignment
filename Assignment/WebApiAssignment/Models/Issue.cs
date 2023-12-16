using WebApiAssignment.Common;

namespace WebApiAssignment.Models
{
    public class Issue
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public Priority Priority { get; set; }
        public IssueType IssueType { get; set; }
    }
}
