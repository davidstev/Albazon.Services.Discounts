using System.ComponentModel.DataAnnotations;

namespace Albazon.Services.Discounts.Api.Models
{
    public class Discount
    {

        public Discount()
        {
            Code = "";
            Amount = 0;
            MinAmount = 0;
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public double Amount { get;set; }
        public int MinAmount { get;set; }

    }
}
