namespace DataAccessLayer.Models
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }
        public virtual IEnumerable<GenreBook> GenreBooks { get; set; }
    }
}
