using System.ComponentModel.DataAnnotations;

namespace ABS3.Model
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string CreatedOn { get; set; }
        public int Score { get; set; }

        public byte[]? Image { get; set; }

        
        public User User { get; set; }

        public string Category { get; set; }
    }
}
