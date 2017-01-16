using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LearningMVC.Models
{
    public class Album
    {
        public int AlbumID { get; set; }

        [Required()]
        [Display(Name = "Artist")]
        public int ArtistID { get; set; }

        [Required()]
        public string Title { get; set; }

        public Artist Artist { get; set; }

        public List<Review> Reviews { get; set; }
    }
}