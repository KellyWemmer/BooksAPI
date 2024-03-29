﻿using System.ComponentModel.DataAnnotations;

namespace BooksAPI_Server.Models
{
    public class Finished
    {
        [Key]
        public int Id { get; set; }
        public string Key { get; set; }
        public string Title { get; set; }

        public int CoverI { get; set; }

        public string TenDigitIsbn { get; set; }
        public string ThirteenDigitIsbn { get; set; }

        //Sets many to many relationship
        public ICollection<FinishedAuthor> FinishedAuthors { get; set; }
    }
}
