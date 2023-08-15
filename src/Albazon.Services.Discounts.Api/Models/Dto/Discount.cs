namespace Albazon.Services.Discounts.Api.Models.Dto
{
    public class Discount
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public double Amount { get; set; }
        public int MinAmount { get; set; }
    }
}
