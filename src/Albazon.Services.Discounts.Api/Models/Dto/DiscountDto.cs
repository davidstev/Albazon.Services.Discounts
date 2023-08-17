namespace Albazon.Services.Discounts.Api.Models.Dto
{
    public class DiscountDto
    {

        public DiscountDto()
        {
            Code = "";
            Amount = 0;
            MinAmount = 0;
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public double Amount { get; set; }
        public int MinAmount { get; set; }
    }
}
