using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using TeduShop.Model.Abstract;


namespace TeduShop.Model.Models
{
    [Table("Products")]
    public class Product : Audiable
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Alias { set; get; }
        public int CategoryID { set; get; }      
        public string Image { set; get; }
        public XElement MoreImages { set; get; }
        public decimal Price { set; get; }
        public decimal? PromotionPrice { set; get; }
        public int? Warranty { set; get; }
        public string Description { set; get; }
        public string Content { set; get; }

        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }




    }
}
