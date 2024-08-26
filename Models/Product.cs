using System.ComponentModel.DataAnnotations;

namespace Day1_Demo.Models
{
    public class Product
    {
        public string Name {get; set; }
        [Required(ErrorMessage ="Enter Code of product !!!")]
        public int Code { get; set; }
        [Required(ErrorMessage = "Enter Price of product !!!")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Enter Count of product !!!")]
        public int count { get; set; }
        [Required(ErrorMessage = "Enter Enter Company name !!!")]
        public List<Company> Companies { get; set; }    
        
        public int CompanyID { get; set; }
    }
}
