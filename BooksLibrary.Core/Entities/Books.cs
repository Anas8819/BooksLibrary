using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksLibrary.Core.Entities
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        public string? Author { get; set; }
    }
}
