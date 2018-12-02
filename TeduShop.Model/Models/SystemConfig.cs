using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("SystemConfigs")]
    public class SystemConfig
    {
        [Key]
        public int ID { set; get; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Code { set; get; }

        [MaxLength(50)]
        public string ValueStrig { set; get; }

        public int? ValueInt { set; get; }
    }
}