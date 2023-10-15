using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Price : BaseEntity
    {
        public int BookId { get; set; }
        public decimal PriceValue { get; set; }
        public string Currency { get; set; }
        public DateTime Date { get; set; }
    }
}