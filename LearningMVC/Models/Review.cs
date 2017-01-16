using System.ComponentModel.DataAnnotations;

namespace LearningMVC.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        public int AlbumID { get; set; }

        public Album Album { get; set; }

        public string Content { get; set; }

        [Required()]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string ReviewerEmail { get; set; }
    }
}