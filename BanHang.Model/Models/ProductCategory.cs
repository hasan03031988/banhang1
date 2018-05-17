using BanHang.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BanHang.Model.Models
{
    [Table("ProductCategories")]
    public class ProductCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        public string Alias { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        public string ParentID { set; get; }

        public string DisplayOrder { set; get; }
        [MaxLength(256)]
        public string Image { set; get; }

        public string HomeFlag { set; get; }

        public virtual IEnumerable<Product> Products { set; get; }
    }
}