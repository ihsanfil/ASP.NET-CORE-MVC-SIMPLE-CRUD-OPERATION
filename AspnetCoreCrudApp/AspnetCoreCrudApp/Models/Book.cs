using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCoreCrudApp.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Başlık alanını doldurmak zorunludur !")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Açıklama alanını doldurmak zorunludur !")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Kitap türü alanını doldurmak zorunludur !")]
        public string Type { get; set; }

        public DateTime PublishDate { get; set; }
        [Required(ErrorMessage = "Fiyat doldurmak zorunludur !")]

        public double Price { get; set; }
        [Required(ErrorMessage = "Adet doldurmak zorunludur !")]

        public string BookLang { get; set; }

        public int StockQuantity { get; set; }
        public Category Category { get; set; }
    }
}
