using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class GenreBook : BaseEntity
    {
        public int BookId { get; set; }
        public int GenreId { get; set; }
    }
}
