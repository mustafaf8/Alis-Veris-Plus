using System.ComponentModel.DataAnnotations;

namespace Alis_Veris_Plus.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ürün adı zorunludur.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Ürün fiyatı zorunludur.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Fiyat geçersiz.")]
        public decimal Price { get; set; }

        // ImageUrl alanını ekleyin
        public string ImageUrl { get; set; } // Resim URL'si için alan


        // Description alanını ekleyin
        public string Description { get; set; } // Açıklama alanı
    }
}
