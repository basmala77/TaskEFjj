namespace example.Model
{
    public class Reviewer
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public ICollection<Review> Reviews { get; set; }

    }
}
