using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCoreCrudApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public DateTime PublishDate { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }
        public Category Category { get; set; }
    }
}
