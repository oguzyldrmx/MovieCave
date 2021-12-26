using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieCave.Models
{
    public class Movies
    {
        public int Id { get; set; }

        public string MovieName { get; set; }

        public int? Year { get; set; }

        public string Subject { get; set; }
        [DisplayName("Banner")]
        public string Banner { get; set; }

        [NotMapped]
        [DisplayName("Upload Banner File")]
        public IFormFile BannerFile { get; set; }

        public string Trailer { get; set; }

        [DisplayName("Category")]
        public int? CategoriesId { get; set; }

        //[ForeignKey("CategoryId")]
        public Categories Categories { get; set; }
    }
}
