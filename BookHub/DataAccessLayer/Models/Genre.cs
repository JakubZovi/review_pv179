using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }
        public List<int> GenreBookId { get; set; } = new List<int>();
    }
}
