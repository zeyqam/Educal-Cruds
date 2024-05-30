namespace Educal_PB101.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool SoftDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
