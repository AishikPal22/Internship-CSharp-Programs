namespace ArchiveManagement
{
    public class Book
    {
        public string MemberID { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string IssueDate { get; set; }
        public string ReturnDate { get; set; }
        public double Penalty { get; set; }

        public Book(string id, string name, string genre, string issuedate, string returndate, double penalty)
        {
            MemberID = id;
            Name = name;
            Genre = genre;
            IssueDate = issuedate;
            ReturnDate = returndate;
            Penalty = penalty;
        }
    }
}