using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safonchik40331Labs.Domain.Entites
{
    public class Book
    {
        public int Id { get; set; } // id книги

        public string Title { get; set; } // название книги

        public string Description { get; set; } // краткое описание

        public int Rating { get; set; } // рейтинг книги 

        public string? CoverImage { get; set; } // путь к файлу обложки

        // Навигационные свойства
        /// <summary>
        /// автор книги
        /// </summary>
        public int AuthorId { get; set; }
        public Author? Author { get; set; }
    }
}
