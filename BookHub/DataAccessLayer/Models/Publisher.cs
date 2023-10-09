using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Publisher : BaseEntity
    {
        public string Name { get; set; }
        public string EMail { get; set; }
        public string BookId { get; set; }
    }
}
