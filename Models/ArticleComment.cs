using System;

namespace MovieCave.Models
{
    public class ArticleComment
    {
        public int Id { get; set; } 

        public string Comments { get; set; }

        public DateTime PushlishedDate { get; set; }

        public int MovieId { get; set; }

        public Movies Movies { get; set; }

        public int Rating { get; set; }
    }
}
