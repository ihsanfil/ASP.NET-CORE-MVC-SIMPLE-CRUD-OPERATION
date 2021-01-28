using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCoreCrudApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Kategori ismini doldurmak zorunludur !")]
        public string CategoryName { get; set; }
        public string CategoryLang{ get; set; }
        public string CategoryDate{ get; set; }
        public List<Book> Books { get; set; }
    }
}
