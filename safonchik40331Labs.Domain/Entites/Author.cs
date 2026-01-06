using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safonchik40331Labs.Domain.Entites
{
    public class Author
    {
        public int Id { get; set; } // id автора

        public string Name { get; set; } // имя автора

        public string NormalizedName { get; set; } // нормализованное имя для URL
    }
}
